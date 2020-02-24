namespace POSchemasAddress {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"POAddress",@"POAddress")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"POAddress"})]
    public sealed class POAddress : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""POAddress"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""POAddress"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""POAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""name"" type=""xs:string"" />
        <xs:element name=""street"" type=""xs:string"" />
        <xs:element name=""city"" type=""xs:string"" />
        <xs:element name=""state"" type=""xs:string"" />
        <xs:element name=""zip"" type=""xs:string"" />
      </xs:sequence>
      <xs:attribute name=""country"">
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""US"" />
            <xs:enumeration value=""CA"" />
            <xs:enumeration value=""UK"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public POAddress() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "POAddress";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
