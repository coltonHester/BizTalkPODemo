namespace POSchemaGenerated.PartnerPOSchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"POSchemaGeneratedPartnerPOSchema",@"purchaseOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"purchaseOrder"})]
    public sealed class PartnerPOSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns=""POSchemaGeneratedPartnerPOSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://POSchemaGenerated.PropertySchema"" targetNamespace=""POSchemaGeneratedPartnerPOSchema"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:annotation>
    <xsd:documentation xml:lang=""en"">
      Purchase order schema for Example.com.
      Copyright 2000 Example.com. All rights reserved.
    </xsd:documentation>
  </xsd:annotation>
  <xsd:element name=""purchaseOrder"" type=""PurchaseOrderType"" />
  <xsd:complexType name=""PurchaseOrderType"">
    <xsd:sequence>
      <xsd:element name=""shipTo"" type=""USAddress"" />
      <xsd:element name=""billTo"" type=""USAddress"" />
      <xsd:element minOccurs=""0"" maxOccurs=""1"" name=""comment"" type=""xsd:string"" />
      <xsd:element name=""items"" type=""Items"" />
    </xsd:sequence>
    <xsd:attribute name=""orderDate"" type=""xsd:date"" />
  </xsd:complexType>
  <xsd:complexType name=""USAddress"">
    <xsd:sequence>
      <xsd:element name=""name"" type=""xsd:string"" />
      <xsd:element name=""street"" type=""xsd:string"" />
      <xsd:element name=""city"" type=""xsd:string"" />
      <xsd:element name=""state"" type=""xsd:string"" />
      <xsd:element name=""zip"" type=""xsd:decimal"" />
    </xsd:sequence>
    <xsd:attribute fixed=""US"" name=""country"" type=""xsd:NMTOKEN"" />
  </xsd:complexType>
  <xsd:complexType name=""Items"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""item"">
        <xsd:complexType>
          <xsd:sequence>
            <xsd:element name=""productName"" type=""xsd:string"" />
            <xsd:element name=""quantity"">
              <xsd:simpleType>
                <xsd:restriction base=""xsd:positiveInteger"">
                  <xsd:maxExclusive value=""100"" />
                </xsd:restriction>
              </xsd:simpleType>
            </xsd:element>
            <xsd:element name=""USPrice"" type=""xsd:decimal"" />
            <xsd:element minOccurs=""0"" name=""comment"" type=""xsd:string"" />
            <xsd:element minOccurs=""0"" name=""shipDate"" type=""xsd:date"" />
          </xsd:sequence>
          <xsd:attribute name=""partNum"" type=""SKU"" use=""required"" />
        </xsd:complexType>
      </xsd:element>
    </xsd:sequence>
  </xsd:complexType>
  <xsd:simpleType name=""SKU"">
    <xsd:restriction base=""xsd:string"">
      <xsd:pattern value=""\d{3}-[A-Z]{2}"" />
    </xsd:restriction>
  </xsd:simpleType>
</xsd:schema>";
        
        public PartnerPOSchema() {
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
