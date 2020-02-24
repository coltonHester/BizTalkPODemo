namespace POMaps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POSchemaGenerated.PartnerPOSchema.PartnerPOSchema", typeof(global::POSchemaGenerated.PartnerPOSchema.PartnerPOSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"POSchemaGenerated.stdPurchaseOrder", typeof(global::POSchemaGenerated.stdPurchaseOrder))]
    public sealed class PartnerPOMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""POSchemaGeneratedPartnerPOSchema"" xmlns:ns0=""stdPOSchema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:purchaseOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:purchaseOrder"">
    <ns0:stdPurchaseOrder>
      <xsl:attribute name=""PONumber"">
        <xsl:text>123</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""PODateTimeReceived"">
        <xsl:text>11/30/2008 12:00:00 AM</xsl:text>
      </xsl:attribute>
      <xsl:if test=""@orderDate"">
        <xsl:attribute name=""POCustDate"">
          <xsl:value-of select=""@orderDate"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""comment"">
        <xsl:attribute name=""POComment"">
          <xsl:value-of select=""comment/text()"" />
        </xsl:attribute>
      </xsl:if>
      <POShipToData>
        <xsl:attribute name=""country"">
          <xsl:text>US</xsl:text>
        </xsl:attribute>
        <name>
          <xsl:value-of select=""shipTo/name/text()"" />
        </name>
        <street>
          <xsl:value-of select=""shipTo/street/text()"" />
        </street>
        <city>
          <xsl:value-of select=""shipTo/city/text()"" />
        </city>
        <state>
          <xsl:value-of select=""shipTo/state/text()"" />
        </state>
        <zip>
          <xsl:value-of select=""shipTo/zip/text()"" />
        </zip>
        <xsl:value-of select=""shipTo/text()"" />
      </POShipToData>
      <POBillToData>
        <xsl:attribute name=""country"">
          <xsl:text>US</xsl:text>
        </xsl:attribute>
        <name>
          <xsl:value-of select=""billTo/name/text()"" />
        </name>
        <street>
          <xsl:value-of select=""billTo/street/text()"" />
        </street>
        <city>
          <xsl:value-of select=""billTo/city/text()"" />
        </city>
        <state>
          <xsl:value-of select=""billTo/state/text()"" />
        </state>
        <zip>
          <xsl:value-of select=""billTo/zip/text()"" />
        </zip>
        <xsl:value-of select=""billTo/text()"" />
      </POBillToData>
      <POItems>
        <xsl:for-each select=""items/item"">
          <POItem>
            <xsl:attribute name=""ProductNumber"">
              <xsl:value-of select=""@partNum"" />
            </xsl:attribute>
            <ProductName>
              <xsl:value-of select=""productName/text()"" />
            </ProductName>
            <Quantity>
              <xsl:value-of select=""quantity/text()"" />
            </Quantity>
            <USPrice>
              <xsl:value-of select=""USPrice/text()"" />
            </USPrice>
            <xsl:if test=""comment"">
              <Comment>
                <xsl:value-of select=""comment/text()"" />
              </Comment>
            </xsl:if>
            <xsl:if test=""shipDate"">
              <ShipDate>
                <xsl:value-of select=""shipDate/text()"" />
              </ShipDate>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </POItem>
        </xsl:for-each>
        <xsl:value-of select=""items/text()"" />
      </POItems>
      <xsl:value-of select=""./text()"" />
    </ns0:stdPurchaseOrder>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"POSchemaGenerated.PartnerPOSchema.PartnerPOSchema";
        
        private const global::POSchemaGenerated.PartnerPOSchema.PartnerPOSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"POSchemaGenerated.stdPurchaseOrder";
        
        private const global::POSchemaGenerated.stdPurchaseOrder _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"POSchemaGenerated.PartnerPOSchema.PartnerPOSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"POSchemaGenerated.stdPurchaseOrder";
                return _TrgSchemas;
            }
        }
    }
}
