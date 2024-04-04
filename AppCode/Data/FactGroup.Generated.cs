// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "FactGroup.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class FactGroup
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.02
// App/Edition: Counter/
// User:        2sic Web-Developer
// When:        2024-04-04 13:28:00Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for FactGroup 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// FactGroup data. <br/>
  /// Generated 2024-04-04 13:28:00Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Background`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class FactGroup: AutoGenerated.ZagFactGroup
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.FactGroup in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagFactGroup: Custom.Data.CustomItem
  {
    /// <summary>
    /// Background as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Background")
    /// </summary>
    public string Background => _item.Url("Background");

    /// <summary>
    /// Get the file object for Background - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile BackgroundFile => _item.File("Background");

    /// <summary>
    /// Get the folder object for Background.
    /// </summary>
    public IFolder BackgroundFolder => _item.Folder("Background");

    /// <summary>
    /// HideTitle as bool. <br/>
    /// To get nullable use .Get("HideTitle") as bool?;
    /// </summary>
    public bool HideTitle => _item.Bool("HideTitle");

    /// <summary>
    /// TextColor as bool. <br/>
    /// To get nullable use .Get("TextColor") as bool?;
    /// </summary>
    public bool TextColor => _item.Bool("TextColor");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public new string Title => _item.String("Title", fallback: "");
  }
}