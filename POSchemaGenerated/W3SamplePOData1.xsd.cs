namespace POSchemaGenerated {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"shipTo", @"billTo", @"comment", @"items"})]
    public sealed class W3SamplePOData1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""shipTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""name"" type=""xs:string"" />
        <xs:element name=""street"" type=""xs:string"" />
        <xs:element name=""city"" type=""xs:string"" />
        <xs:element name=""state"" type=""xs:string"" />
        <xs:element name=""zip"" type=""xs:unsignedInt"" />
      </xs:sequence>
      <xs:attribute name=""country"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""billTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""name"" type=""xs:string"" />
        <xs:element name=""street"" type=""xs:string"" />
        <xs:element name=""city"" type=""xs:string"" />
        <xs:element name=""state"" type=""xs:string"" />
        <xs:element name=""zip"" type=""xs:unsignedInt"" />
      </xs:sequence>
      <xs:attribute name=""country"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""comment"" type=""xs:string"" />
  <xs:element name=""items"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""productName"" type=""xs:string"" />
              <xs:element name=""quantity"" type=""xs:unsignedByte"" />
              <xs:element name=""USPrice"" type=""xs:decimal"" />
              <xs:element minOccurs=""0"" name=""shipDate"" type=""xs:date"" />
              <xs:element minOccurs=""0"" name=""comment"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""partNum"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public W3SamplePOData1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "shipTo";
                _RootElements[1] = "billTo";
                _RootElements[2] = "comment";
                _RootElements[3] = "items";
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
        
        [Schema(@"",@"shipTo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"shipTo"})]
        public sealed class shipTo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public shipTo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "shipTo";
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
        
        [Schema(@"",@"billTo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"billTo"})]
        public sealed class billTo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public billTo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "billTo";
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
        
        [Schema(@"",@"comment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"comment"})]
        public sealed class comment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public comment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "comment";
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
        
        [Schema(@"",@"items")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"items"})]
        public sealed class items : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public items() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "items";
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
}
