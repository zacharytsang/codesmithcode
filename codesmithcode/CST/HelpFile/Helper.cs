using System;
using System.IO;
using System.Xml;
using System.Data;
using SchemaExplorer;
using System.Web;

/// <summary>
/// PK strategy of a table
/// </summary>
public enum PKStrategy {
    Identity, Customize
}

/// <summary>
/// Include some methods for help
/// </summary>
public static class Helper {

    #region For main template

    /// <summary>
    /// Copy whole directory from source path to destination path
    /// </summary>
    /// <param name="sourcePath">Like: D:\MySolution</param>
    /// <param name="destinationPath">Like: F:\MySolution</param>
    public static void CopyWholeDirectory(string sourcePath, string destinationPath) {
        // create directory
        Directory.CreateDirectory(destinationPath);
        // copy file
        DirectoryInfo di = new DirectoryInfo(sourcePath);
        foreach (FileInfo fi in di.GetFiles()) {
            File.Copy(fi.FullName, destinationPath + "\\" + fi.Name);
        }
        // recursion
        foreach (DirectoryInfo subDi in di.GetDirectories()) {
            CopyWholeDirectory(subDi.FullName, destinationPath + "\\" + subDi.Name);
        }
    }


	
	public static void Make_csproj_IncludeFile(string csprojPath, string filePath) {
        XmlDocument doc = new XmlDocument();
        doc.Load(csprojPath);

        XmlNode root = doc.DocumentElement;
        foreach (XmlNode node in root.ChildNodes) {
            // locate to the "ItemGroup" node which includes compile files
            if (node.Name == "ItemGroup" && node.ChildNodes[0].Name == "Compile")
            {
                    XmlNode PropertiesNode = node.ChildNodes[0].Clone();
                    if (!NodeisExists(root, filePath)){
						XmlNode createNode = node.ChildNodes[0].Clone();
						createNode.Attributes["Include"].Value = filePath;
						node.AppendChild(createNode);
					}
            }
        }
        doc.Save(csprojPath);
    }
	
	public static bool NodeisExists(XmlNode root, string path)
    {
            bool isExist = false;
            foreach (XmlNode node in root.ChildNodes)
            {
                // locate to the "ItemGroup" node which includes compile files
                if (node.Name == "ItemGroup" && node.ChildNodes[0].Name == "Compile")
                {
                    for (int i = 0; i < node.ChildNodes.Count;i++ )
                    {
                        if (node.ChildNodes[i].Attributes["Include"].InnerText == path)
                        {
                            isExist = true;
                            break;
                        }

                    }
                }
            }

            return isExist;
    }


    /// <summary>
    /// Create the connection string node of Web.Config
    /// </summary>
    /// <param name="webConfigPath"></param>
    /// <param name="connectionString"></param>
    public static void CreateWebConfigConnectionString(string webConfigPath, string connectionString) {
        XmlDocument doc = new XmlDocument();
        doc.Load(webConfigPath);
        XmlNode root = doc.DocumentElement;
        XmlNode node = root.SelectSingleNode("connectionStrings");
        // node "add"
        XmlNode createNode = doc.CreateNode(XmlNodeType.Element, "add", "");
        // Attribute "name"
        XmlAttribute xaName = doc.CreateAttribute("name");
        xaName.Value = "SQLConnString";
        createNode.Attributes.Append(xaName);
        // Attribute "connectionString"
        XmlAttribute xaConn = doc.CreateAttribute("connectionString");
        xaConn.Value = connectionString;
        createNode.Attributes.Append(xaConn);
        // append node
        node.AppendChild(createNode);
        doc.Save(webConfigPath);
    }

    #endregion

    #region Utility methods

    /// <summary>
    /// Convert string to Pascal naming method
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string ToPascal(string str) {
        return str[0].ToString().ToUpper() + str.Substring(1);
    }

    /// <summary>
    /// Convert string to Camel naming method
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string ToCamel(string str) {
        return str[0].ToString().ToLower() + str.Substring(1);
    }

    /// <summary>
    /// Get PK column of a table
    /// </summary>
    /// <param name="table"></param>
    /// <returns></returns>
    public static ColumnSchema GetPKColunm(TableSchema table) {
        foreach (ColumnSchema col in table.Columns) {
            if (col.IsPrimaryKeyMember) {
                return col;
            }
        }
        return null;
    }

    /// <summary>
    /// Get PK column C Sharp type
    /// </summary>
    /// <param name="ts"></param>
    /// <returns></returns>
    public static string GetPKColumnCSharpType(TableSchema ts) {
        return GetCSharpType(GetPKColunm(ts)); 
    }

    /// <summary>
    /// Get PK column name
    /// </summary>
    /// <param name="ts"></param>
    /// <returns></returns>
    public static string GetPKColName(TableSchema ts) {
        return GetPKColunm(ts).Name;
    }

    /// <summary>
    /// Get PK column Pascal name
    /// </summary>
    /// <param name="ts"></param>
    /// <returns></returns>
    public static string GetPKColPascalName(TableSchema ts) {
        return ToPascal(GetPKColName(ts));
    }

    /// <summary>
    /// Get PK table reference FK column
    /// </summary>
    /// <param name="ts"></param>
    /// <param name="fkCol"></param>
    /// <returns></returns>
    public static TableSchema GetPKTableRefFK(TableSchema ts, ColumnSchema fkCol) {
        foreach (TableKeySchema tk in ts.ForeignKeys) {
            if (tk.ForeignKeyMemberColumns.Contains(fkCol)) {
                return tk.PrimaryKeyTable;
            }
        }
        return null;
    }

    /// <summary>
    /// Get PK class name reference this FK column
    /// </summary>
    /// <param name="fkCol"></param>
    /// <returns></returns>
    public static string GetPKClassNameRefFK(TableSchema ts, ColumnSchema fkCol) {
        return ToPascal(GetPKTableRefFK(ts, fkCol).Name);
    }

    /// <summary>
    /// Get PK Pascal name of PK table reference FK column
    /// </summary>
    /// <param name="ts"></param>
    /// <param name="fkCol"></param>
    /// <returns></returns>
    public static string GetPKTablePKPascalNameRefFK(TableSchema ts, ColumnSchema fkCol) {
        return GetPKColPascalName(GetPKTableRefFK(ts, fkCol));
    }

    /// <summary>
    /// Get C Sharp type from the DB type of the column
    /// </summary>
    /// <param name="column"></param>
    /// <returns></returns>
    public static string GetCSharpType(ColumnSchema column) {
        string str = GetCSharpVariableType(column);
        //if (column.IsPrimaryKeyMember || column.IsForeignKeyMember || !column.AllowDBNull) {
        if (column.IsPrimaryKeyMember || column.IsForeignKeyMember ) {
			if (str.Contains("Nullable<")) {
                str = str.Split('<', '>')[1];
            }
        }
        return str;
    }

    /// <summary>
    /// Get C Sharp type from the DB type of the column
    /// </summary>
    /// <param name="column"></param>
    /// <returns></returns>
    public static string GetCSharpVariableType(ColumnSchema column) {
        switch (column.DataType) {
            case DbType.AnsiString: return "string";
            case DbType.AnsiStringFixedLength: return "string";
            case DbType.Binary: return "byte[]";
            case DbType.Boolean: return "Nullable<bool>";
            case DbType.Byte: return "Nullable<byte>";
            case DbType.Currency: return "Nullable<decimal>";
            case DbType.Date: return "Nullable<DateTime>";
            case DbType.DateTime: return "Nullable<DateTime>";
            case DbType.Decimal: return "Nullable<decimal>";
            case DbType.Double: return "Nullable<double>";
            case DbType.Guid: return "Nullable<Guid>";
            case DbType.Int16: return "Nullable<short>";
            case DbType.Int32: return "Nullable<int>";
            case DbType.Int64: return "Nullable<long>";
            case DbType.Object: return "object";
            case DbType.SByte: return "Nullable<sbyte>";
            case DbType.Single: return "Nullable<float>";
            case DbType.String: return "string";
            case DbType.StringFixedLength: return "string";
            case DbType.Time: return "Nullable<TimeSpan>";
            case DbType.UInt16: return "Nullable<ushort>";
            case DbType.UInt32: return "Nullable<uint>";
            case DbType.UInt64: return "Nullable<ulong>";
            case DbType.VarNumeric: return "Nullable<decimal>";
            default: return "__UNKNOWN__" + column.NativeType;
        }
    }

    #endregion
	
	#region For model template

    /// <summary>
    /// Like: private string userName;
    ///   or  private Nullable<int> age;
    ///   or  private UserState stateId;
    /// </summary>
    /// <param name="col"></param>
    /// <returns></returns>
    public static string GetPrivateField(TableSchema ts, ColumnSchema col) {
        string str = "private {0} {1};";
        string str0 = col.IsForeignKeyMember ? GetPKClassNameRefFK(ts, col) : GetCSharpType(col);
        string str1 = ToCamel(col.Name);
        return string.Format(str, str0, str1);
    }

    /// <summary>
    /// Like: public string UserName
    ///   or  public Nullable<int> Age
    ///   or  public UserState StateId;
    /// </summary>
    /// <param name="col"></param>
    /// <returns></returns>
    public static string GetPublicProperty(TableSchema ts, ColumnSchema col) {
        string str = "public {0} {1}";
        string str0 = col.IsForeignKeyMember ? GetPKClassNameRefFK(ts, col) : GetCSharpType(col);
        string str1 = ToPascal(col.Name);
        return string.Format(str, str0, str1);
    }

    #endregion

}
