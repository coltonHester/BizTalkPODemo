namespace purchaseOrder {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"POSchema.purchaseOrder",@"purchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"purchaseOrder"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POSchemasAddress.POAddress", typeof(global::POSchemasAddress.POAddress))]
    public sealed class POSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""POSchema.purchaseOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:addr=""POAddress"" targetNamespace=""POSchema.purchaseOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""POSchemasAddress.POAddress"" namespace=""POAddress"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""POAddress"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""purchaseOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""shipTo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""addr:POAddress"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""billTo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""addr:POAddress"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""comment"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""item"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""productName"" type=""xs:string"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""quantity"" type=""xs:integer"" />
                    <xs:element minOccurs=""1"" maxOccurs=""1"" name=""USPrice"" type=""xs:decimal"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""comment"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""shipDate"" type=""xs:date"" />
                  </xs:sequence>
                  <xs:attribute name=""partNum"" type=""xs:string"" use=""required"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""orderDate"" type=""xs:date"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public POSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "purchaseOrder";
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
