using System;
using System.Xml;

namespace factura_electronica
{
    public class dte_norma
    {
        public XmlDocument doc = new XmlDocument();
        private XmlElement docu;
        private XmlElement TipoDTE;
        private XmlElement enca;
        private XmlElement IdDoc;
        private XmlElement Folio;
        private XmlElement FchEmis;
        private XmlElement emisor;
        private XmlElement RUTEmisor;
        private XmlElement RznSoc;
        private XmlElement GiroEmis;
        private XmlElement Acteco;
        private XmlElement DirOrigen;
        private XmlElement CmnaOrigen;
        private XmlElement CiudadOrigen;
        private XmlElement Receptor;
        private XmlElement RUTRecep;
        private XmlElement RznSocRecep;
        private XmlElement GiroRecep;
        private XmlElement DirRecep;
        private XmlElement CmnaRecep;
        private XmlElement CiudadRecep;
        private XmlElement Totales;
        private XmlElement MntNeto;
        private XmlElement TasaIVA;
        private XmlElement IVA;
        private XmlElement MntTotal;






        private XmlElement Detalle;
        private XmlElement CdgItem;
        private XmlElement TpoCodigo;
        private XmlElement VlrCodigo;
        private XmlElement NroLinDet;
        private XmlElement NmbItem;
        private XmlElement DscItem;

        private XmlElement QtyItem;
        private XmlElement UnmdItem;
        private XmlElement PrcItem;
        private XmlElement MontoItem;

        private XmlElement Adjuntos;
        private XmlElement Observacion;
        private XmlElement Impresora;
        private XmlElement Copias;

        public dte_norma()
        {

        }
        public void esquema()
        {

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            this.docu = doc.CreateElement("Documento");
            this.enca = doc.CreateElement("Encabezado");
            this.IdDoc = doc.CreateElement("IdDoc");
            this.TipoDTE = doc.CreateElement("TipoDTE");
            this.Folio = doc.CreateElement("Folio");
            this.FchEmis = doc.CreateElement("FchEmis");

            this.emisor = doc.CreateElement("Emisor");
            this.RUTEmisor = doc.CreateElement("RUTEmisor");
            this.RznSoc = doc.CreateElement("RznSoc");
            this.GiroEmis = doc.CreateElement("GiroEmis");
            this.Acteco = doc.CreateElement("Acteco");
            this.DirOrigen = doc.CreateElement("DirOrigen");
            this.CmnaOrigen = doc.CreateElement("CmnaOrigen");
            this.CiudadOrigen = doc.CreateElement("CiudadOrigen");




            this.Receptor = doc.CreateElement("Receptor");
            this.RUTRecep = doc.CreateElement("RUTRecep");
            this.RznSocRecep = doc.CreateElement("RznSocRecep");
            this.GiroRecep = doc.CreateElement("GiroRecep");
            this.DirRecep = doc.CreateElement("DirRecep");
            this.CmnaRecep = doc.CreateElement("CmnaRecep");
            this.CiudadRecep = doc.CreateElement("CiudadRecep");

            this.Totales = doc.CreateElement("Totales");
            this.MntNeto = doc.CreateElement("MntNeto");
            this.TasaIVA = doc.CreateElement("TasaIVA");
            this.IVA = doc.CreateElement("IVA");
            this.MntTotal = doc.CreateElement("MntTotal");

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.DscItem = doc.CreateElement("DscItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");





            this.Adjuntos = doc.CreateElement("Adjuntos");
            this.Observacion = doc.CreateElement("Observacion");
            this.Impresora = doc.CreateElement("Impresora");
            this.Copias = doc.CreateElement("Copias");



            doc.AppendChild(docu);
            docu.AppendChild(enca);

            enca.AppendChild(IdDoc);
            IdDoc.AppendChild(TipoDTE);
            IdDoc.AppendChild(Folio);
            IdDoc.AppendChild(FchEmis);

            enca.AppendChild(emisor);
            emisor.AppendChild(RUTEmisor);
            emisor.AppendChild(RznSoc);
            emisor.AppendChild(Receptor);
            emisor.AppendChild(GiroEmis);
            emisor.AppendChild(Acteco);
            emisor.AppendChild(DirOrigen);
            emisor.AppendChild(CmnaOrigen);
            emisor.AppendChild(CiudadOrigen);


            enca.AppendChild(Receptor);
            Receptor.AppendChild(RUTRecep);
            Receptor.AppendChild(RznSocRecep);
            Receptor.AppendChild(GiroRecep);
            Receptor.AppendChild(DirRecep);
            Receptor.AppendChild(CmnaRecep);
            Receptor.AppendChild(CiudadRecep);


            enca.AppendChild(Totales);
            Totales.AppendChild(MntNeto);
            Totales.AppendChild(TasaIVA);
            Totales.AppendChild(IVA);
            Totales.AppendChild(MntTotal);





        }

        public void docucabecera(String tipodoc, String folioc, String fechaemi)
        {
            TipoDTE.AppendChild(doc.CreateTextNode(tipodoc));
            Folio.AppendChild(doc.CreateTextNode(folioc));
            FchEmis.AppendChild(doc.CreateTextNode(fechaemi));
        }

        public void docuemisor(String RUTEmisord, String RznSocd, String GiroEmisd, String Actecod, String DirOrigend, String CmnaOrigend, String CiudadOrigend)
        {
            RUTEmisor.AppendChild(doc.CreateTextNode(RUTEmisord));
            RznSoc.AppendChild(doc.CreateTextNode(RznSocd));
            GiroEmis.AppendChild(doc.CreateTextNode(GiroEmisd));
            Acteco.AppendChild(doc.CreateTextNode(Actecod));
            DirOrigen.AppendChild(doc.CreateTextNode(DirOrigend));
            CmnaOrigen.AppendChild(doc.CreateTextNode(CmnaOrigend));
            CiudadOrigen.AppendChild(doc.CreateTextNode(CiudadOrigend));
        }

        public void docureceptor(string RUTRecepd, string RznSocRecepd, string GiroRecepd, string DirRecepd, string CmnaRecepd, string CiudadRecepd)
        {
            RUTRecep.AppendChild(doc.CreateTextNode(RUTRecepd));
            RznSocRecep.AppendChild(doc.CreateTextNode(RznSocRecepd));
            GiroRecep.AppendChild(doc.CreateTextNode(GiroRecepd));
            DirRecep.AppendChild(doc.CreateTextNode(DirRecepd));
            CmnaRecep.AppendChild(doc.CreateTextNode(CmnaRecepd));
            CiudadRecep.AppendChild(doc.CreateTextNode(CiudadRecepd));

        }

        public void docutotal(string MntNetod, string TasaIVAd, string IVAd, string MntTotald)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
        }


        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");



            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);

            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));

            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }



        public void docudetalle(string NroLinDetd, string NmbItemd, string DscItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");



            this.NmbItem = doc.CreateElement("NmbItem");
            this.DscItem = doc.CreateElement("DscItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);

            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));

            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            DscItem.AppendChild(doc.CreateTextNode(DscItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }


        public void docuadjuntos(string Observaciond, string Impresorad, string Copiasd)
        {

            docu.AppendChild(Adjuntos);
            Adjuntos.AppendChild(Observacion);
            Adjuntos.AppendChild(Impresora);
            Adjuntos.AppendChild(Copias);

            Observacion.AppendChild(doc.CreateTextNode(Observaciond));
            Impresora.AppendChild(doc.CreateTextNode(Impresorad));
            Copias.AppendChild(doc.CreateTextNode(Copiasd));
        }
        public void graba(string nombre)
        {
            string d = "C:\\xml_factura\\";
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
        public void graba(string nombre, string ruta)
        {
            string d = ruta;
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
    }

    public class dte_norma_ila
    {
        public XmlDocument doc = new XmlDocument();
        private XmlElement docu;
        private XmlElement TipoDTE;
        private XmlElement enca;
        private XmlElement IdDoc;
        private XmlElement Folio;
        private XmlElement FchEmis;
        private XmlElement emisor;
        private XmlElement RUTEmisor;
        private XmlElement RznSoc;
        private XmlElement GiroEmis;
        private XmlElement Acteco;
        private XmlElement DirOrigen;
        private XmlElement CmnaOrigen;
        private XmlElement CiudadOrigen;
        private XmlElement Receptor;
        private XmlElement RUTRecep;
        private XmlElement RznSocRecep;
        private XmlElement GiroRecep;
        private XmlElement DirRecep;
        private XmlElement CmnaRecep;
        private XmlElement CiudadRecep;
        private XmlElement Totales;
        private XmlElement MntNeto;
        private XmlElement TasaIVA;
        private XmlElement IVA;
        private XmlElement MntTotal;

        private XmlElement ImptoReten;
        private XmlElement TipoImp;
        private XmlElement TasaImp;
        private XmlElement MontoImp;







        private XmlElement Detalle;
        private XmlElement CdgItem;
        private XmlElement TpoCodigo;
        private XmlElement VlrCodigo;
        private XmlElement NroLinDet;
        private XmlElement NmbItem;
        private XmlElement DscItem;

        private XmlElement QtyItem;
        private XmlElement UnmdItem;
        private XmlElement PrcItem;
        private XmlElement CodImpAdic;
        private XmlElement MontoItem;

        private XmlElement Adjuntos;
        private XmlElement Observacion;
        private XmlElement Impresora;
        private XmlElement Copias;

        public dte_norma_ila()
        {

        }
        public void esquema()
        {

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            this.docu = doc.CreateElement("Documento");
            this.enca = doc.CreateElement("Encabezado");
            this.IdDoc = doc.CreateElement("IdDoc");
            this.TipoDTE = doc.CreateElement("TipoDTE");
            this.Folio = doc.CreateElement("Folio");
            this.FchEmis = doc.CreateElement("FchEmis");

            this.emisor = doc.CreateElement("Emisor");
            this.RUTEmisor = doc.CreateElement("RUTEmisor");
            this.RznSoc = doc.CreateElement("RznSoc");
            this.GiroEmis = doc.CreateElement("GiroEmis");
            this.Acteco = doc.CreateElement("Acteco");
            this.DirOrigen = doc.CreateElement("DirOrigen");
            this.CmnaOrigen = doc.CreateElement("CmnaOrigen");
            this.CiudadOrigen = doc.CreateElement("CiudadOrigen");




            this.Receptor = doc.CreateElement("Receptor");
            this.RUTRecep = doc.CreateElement("RUTRecep");
            this.RznSocRecep = doc.CreateElement("RznSocRecep");
            this.GiroRecep = doc.CreateElement("GiroRecep");
            this.DirRecep = doc.CreateElement("DirRecep");
            this.CmnaRecep = doc.CreateElement("CmnaRecep");
            this.CiudadRecep = doc.CreateElement("CiudadRecep");

            this.Totales = doc.CreateElement("Totales");
            this.MntNeto = doc.CreateElement("MntNeto");
            this.TasaIVA = doc.CreateElement("TasaIVA");
            this.IVA = doc.CreateElement("IVA");
            this.MntTotal = doc.CreateElement("MntTotal");

            this.ImptoReten = doc.CreateElement("ImptoReten");
            this.TipoImp = doc.CreateElement("TipoImp");
            this.TasaImp = doc.CreateElement("TasaImp");
            this.MontoImp = doc.CreateElement("MontoImp");


            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.DscItem = doc.CreateElement("DscItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.CodImpAdic = doc.CreateElement("CodImpAdic");
            this.MontoItem = doc.CreateElement("MontoItem");





            this.Adjuntos = doc.CreateElement("Adjuntos");
            this.Observacion = doc.CreateElement("Observacion");
            this.Impresora = doc.CreateElement("Impresora");
            this.Copias = doc.CreateElement("Copias");



            doc.AppendChild(docu);
            docu.AppendChild(enca);

            enca.AppendChild(IdDoc);
            IdDoc.AppendChild(TipoDTE);
            IdDoc.AppendChild(Folio);
            IdDoc.AppendChild(FchEmis);

            enca.AppendChild(emisor);
            emisor.AppendChild(RUTEmisor);
            emisor.AppendChild(RznSoc);
            emisor.AppendChild(Receptor);
            emisor.AppendChild(GiroEmis);
            emisor.AppendChild(Acteco);
            emisor.AppendChild(DirOrigen);
            emisor.AppendChild(CmnaOrigen);
            emisor.AppendChild(CiudadOrigen);


            enca.AppendChild(Receptor);
            Receptor.AppendChild(RUTRecep);
            Receptor.AppendChild(RznSocRecep);
            Receptor.AppendChild(GiroRecep);
            Receptor.AppendChild(DirRecep);
            Receptor.AppendChild(CmnaRecep);
            Receptor.AppendChild(CiudadRecep);


            enca.AppendChild(Totales);
            Totales.AppendChild(MntNeto);
            Totales.AppendChild(TasaIVA);
            Totales.AppendChild(IVA);
            Totales.AppendChild(MntTotal);
            Totales.AppendChild(ImptoReten);
            ImptoReten.AppendChild(TipoImp);
            ImptoReten.AppendChild(TasaImp);
            ImptoReten.AppendChild(MontoImp);







        }

        public void docucabecera(String tipodoc, String folioc, String fechaemi)
        {
            TipoDTE.AppendChild(doc.CreateTextNode(tipodoc));
            Folio.AppendChild(doc.CreateTextNode(folioc));
            FchEmis.AppendChild(doc.CreateTextNode(fechaemi));
        }

        public void docuemisor(String RUTEmisord, String RznSocd, String GiroEmisd, String Actecod, String DirOrigend, String CmnaOrigend, String CiudadOrigend)
        {
            RUTEmisor.AppendChild(doc.CreateTextNode(RUTEmisord));
            RznSoc.AppendChild(doc.CreateTextNode(RznSocd));
            GiroEmis.AppendChild(doc.CreateTextNode(GiroEmisd));
            Acteco.AppendChild(doc.CreateTextNode(Actecod));
            DirOrigen.AppendChild(doc.CreateTextNode(DirOrigend));
            CmnaOrigen.AppendChild(doc.CreateTextNode(CmnaOrigend));
            CiudadOrigen.AppendChild(doc.CreateTextNode(CiudadOrigend));
        }

        public void docureceptor(string RUTRecepd, string RznSocRecepd, string GiroRecepd, string DirRecepd, string CmnaRecepd, string CiudadRecepd)
        {
            RUTRecep.AppendChild(doc.CreateTextNode(RUTRecepd));
            RznSocRecep.AppendChild(doc.CreateTextNode(RznSocRecepd));
            GiroRecep.AppendChild(doc.CreateTextNode(GiroRecepd));
            DirRecep.AppendChild(doc.CreateTextNode(DirRecepd));
            CmnaRecep.AppendChild(doc.CreateTextNode(CmnaRecepd));
            CiudadRecep.AppendChild(doc.CreateTextNode(CiudadRecepd));

        }

        public void docutotal(string MntNetod, string TasaIVAd, string IVAd, string MntTotald, string TipoImpd, string TasaImpd, string MontoImpd)

        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
            TipoImp.AppendChild(doc.CreateTextNode(TipoImpd));
            TasaImp.AppendChild(doc.CreateTextNode(TasaImpd));
            MontoImp.AppendChild(doc.CreateTextNode(MontoImpd));


        }


        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod, string CodImpAdicd)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");



            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.CodImpAdic = doc.CreateElement("CodImpAdic");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);

            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(CodImpAdic);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));

            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            CodImpAdic.AppendChild(doc.CreateTextNode(CodImpAdicd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));
        }



        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");



            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);

            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));

            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }






        public void docuadjuntos(string Observaciond, string Impresorad, string Copiasd)
        {

            docu.AppendChild(Adjuntos);
            Adjuntos.AppendChild(Observacion);
            Adjuntos.AppendChild(Impresora);
            Adjuntos.AppendChild(Copias);

            Observacion.AppendChild(doc.CreateTextNode(Observaciond));
            Impresora.AppendChild(doc.CreateTextNode(Impresorad));
            Copias.AppendChild(doc.CreateTextNode(Copiasd));
        }
        public void graba(string nombre)
        {
            string d = "C:\\xml_factura\\";
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
        public void graba(string nombre, string ruta)
        {
            string d = ruta;
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
    }

    public class dte_liquidacion

    {
        public XmlDocument doc = new XmlDocument();
        private XmlElement docu;
        private XmlElement TipoDTE;
        private XmlElement enca;
        private XmlElement IdDoc;
        private XmlElement Folio;
        private XmlElement FchEmis;
        private XmlElement emisor;
        private XmlElement RUTEmisor;
        private XmlElement RznSoc;
        private XmlElement GiroEmis;
        private XmlElement Acteco;
        private XmlElement DirOrigen;
        private XmlElement CmnaOrigen;
        private XmlElement CiudadOrigen;
        private XmlElement Receptor;
        private XmlElement RUTRecep;
        private XmlElement RznSocRecep;
        private XmlElement GiroRecep;
        private XmlElement DirRecep;
        private XmlElement CmnaRecep;
        private XmlElement CiudadRecep;
        private XmlElement Totales;
        private XmlElement MntNeto;
        private XmlElement TasaIVA;
        private XmlElement IVA;
        private XmlElement MntTotal;

        private XmlElement Detalle;
        private XmlElement NroLinDet;
        private XmlElement CdgItem;
        private XmlElement TpoCodigo;
        private XmlElement VlrCodigo;
        private XmlElement TpoDocLiq;
        private XmlElement NmbItem;
        private XmlElement QtyItem;
        private XmlElement UnmdItem;
        private XmlElement PrcItem;
        private XmlElement MontoItem;

        private XmlElement Comisiones;
        private XmlElement Comisionest;
        private XmlElement NroLinCom;
        private XmlElement TipoMovim;
        private XmlElement Glosa;
        private XmlElement TasaComision;
        private XmlElement ValComNeto;
        private XmlElement ValComExe;
        private XmlElement ValComIVA;

        private XmlElement ValComNetot;
        private XmlElement ValComExet;
        private XmlElement ValComIVAt;

        private XmlElement Referencia;
        private XmlElement NroLinRef;
        private XmlElement TpoDocRef;
        private XmlElement FolioRef;
        private XmlElement FchRef;
        private XmlElement CodRef;
        private XmlElement RazonRef;



        private XmlElement Adjuntos;
        private XmlElement Observacion;
        private XmlElement Impresora;
        private XmlElement Copias;




        public dte_liquidacion()
        {

        }
        public void esquema()
        {

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            this.docu = doc.CreateElement("Liquidacion");
            this.enca = doc.CreateElement("Encabezado");
            this.IdDoc = doc.CreateElement("IdDoc");
            this.TipoDTE = doc.CreateElement("TipoDTE");
            this.Folio = doc.CreateElement("Folio");
            this.FchEmis = doc.CreateElement("FchEmis");

            this.emisor = doc.CreateElement("Emisor");
            this.RUTEmisor = doc.CreateElement("RUTEmisor");
            this.RznSoc = doc.CreateElement("RznSoc");
            this.GiroEmis = doc.CreateElement("GiroEmis");
            this.Acteco = doc.CreateElement("Acteco");
            this.DirOrigen = doc.CreateElement("DirOrigen");
            this.CmnaOrigen = doc.CreateElement("CmnaOrigen");
            this.CiudadOrigen = doc.CreateElement("CiudadOrigen");




            this.Receptor = doc.CreateElement("Receptor");
            this.RUTRecep = doc.CreateElement("RUTRecep");
            this.RznSocRecep = doc.CreateElement("RznSocRecep");
            this.GiroRecep = doc.CreateElement("GiroRecep");
            this.DirRecep = doc.CreateElement("DirRecep");
            this.CmnaRecep = doc.CreateElement("CmnaRecep");
            this.CiudadRecep = doc.CreateElement("CiudadRecep");

            this.Totales = doc.CreateElement("Totales");
            this.MntNeto = doc.CreateElement("MntNeto");
            this.TasaIVA = doc.CreateElement("TasaIVA");
            this.IVA = doc.CreateElement("IVA");
            this.Comisionest = doc.CreateElement("Comisiones");
            this.ValComNetot = doc.CreateElement("ValComNeto");
            this.ValComExet = doc.CreateElement("ValComExe");
            this.ValComIVAt = doc.CreateElement("ValComIVA");
            this.MntTotal = doc.CreateElement("MntTotal");

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");
            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");
            this.TpoDocLiq = doc.CreateElement("TpoDocLiq");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            this.Comisiones = doc.CreateElement("Comisiones");
            this.NroLinCom = doc.CreateElement("NroLinCom");
            this.TipoMovim = doc.CreateElement("TipoMovim");
            this.Glosa = doc.CreateElement("Glosa");
            this.TasaComision = doc.CreateElement("TasaComision");
            this.ValComNeto = doc.CreateElement("ValComNeto");
            this.ValComExe = doc.CreateElement("ValComExe");
            this.ValComIVA = doc.CreateElement("ValComIVA");



            this.Referencia = doc.CreateElement("Referencia");
            this.NroLinRef = doc.CreateElement("NroLinRef");
            this.TpoDocRef = doc.CreateElement("TpoDocRef");
            this.FolioRef = doc.CreateElement("FolioRef");
            this.FchRef = doc.CreateElement("FchRef");
            this.CodRef = doc.CreateElement("CodRef");
            this.RazonRef = doc.CreateElement("RazonRef");


            this.Adjuntos = doc.CreateElement("Adjuntos");
            this.Observacion = doc.CreateElement("Observacion");
            this.Impresora = doc.CreateElement("Impresora");
            this.Copias = doc.CreateElement("Copias");



            doc.AppendChild(docu);
            docu.AppendChild(enca);

            enca.AppendChild(IdDoc);
            IdDoc.AppendChild(TipoDTE);
            IdDoc.AppendChild(Folio);
            IdDoc.AppendChild(FchEmis);

            enca.AppendChild(emisor);
            emisor.AppendChild(RUTEmisor);
            emisor.AppendChild(RznSoc);
            emisor.AppendChild(Receptor);
            emisor.AppendChild(GiroEmis);
            emisor.AppendChild(Acteco);
            emisor.AppendChild(DirOrigen);
            emisor.AppendChild(CmnaOrigen);
            emisor.AppendChild(CiudadOrigen);


            enca.AppendChild(Receptor);
            Receptor.AppendChild(RUTRecep);
            Receptor.AppendChild(RznSocRecep);
            Receptor.AppendChild(GiroRecep);
            Receptor.AppendChild(DirRecep);
            Receptor.AppendChild(CmnaRecep);
            Receptor.AppendChild(CiudadRecep);




            enca.AppendChild(Totales);
            Totales.AppendChild(MntNeto);
            Totales.AppendChild(TasaIVA);
            Totales.AppendChild(IVA);
            Totales.AppendChild(Comisionest);
            Comisionest.AppendChild(ValComNetot);
            Comisionest.AppendChild(ValComExet);
            Comisionest.AppendChild(ValComIVAt);
            Totales.AppendChild(MntTotal);

            docu.AppendChild(Comisiones);
            Comisiones.AppendChild(NroLinCom);
            Comisiones.AppendChild(TipoMovim);
            Comisiones.AppendChild(Glosa);
            Comisiones.AppendChild(TasaComision);
            Comisiones.AppendChild(ValComNeto);
            Comisiones.AppendChild(ValComExe);
            Comisiones.AppendChild(ValComIVA);





        }
        public void docucabecera(String tipodoc, String folioc, String fechaemi)
        {
            TipoDTE.AppendChild(doc.CreateTextNode(tipodoc));
            Folio.AppendChild(doc.CreateTextNode(folioc));
            FchEmis.AppendChild(doc.CreateTextNode(fechaemi));
        }

        public void docuemisor(String RUTEmisord, String RznSocd, String GiroEmisd, String Actecod, String DirOrigend, String CmnaOrigend, String CiudadOrigend)
        {
            RUTEmisor.AppendChild(doc.CreateTextNode(RUTEmisord));
            RznSoc.AppendChild(doc.CreateTextNode(RznSocd));
            GiroEmis.AppendChild(doc.CreateTextNode(GiroEmisd));
            Acteco.AppendChild(doc.CreateTextNode(Actecod));
            DirOrigen.AppendChild(doc.CreateTextNode(DirOrigend));
            CmnaOrigen.AppendChild(doc.CreateTextNode(CmnaOrigend));
            CiudadOrigen.AppendChild(doc.CreateTextNode(CiudadOrigend));
        }

        public void docureceptor(string RUTRecepd, string RznSocRecepd, string GiroRecepd, string DirRecepd, string CmnaRecepd, string CiudadRecepd)
        {
            RUTRecep.AppendChild(doc.CreateTextNode(RUTRecepd));
            RznSocRecep.AppendChild(doc.CreateTextNode(RznSocRecepd));
            GiroRecep.AppendChild(doc.CreateTextNode(GiroRecepd));
            DirRecep.AppendChild(doc.CreateTextNode(DirRecepd));
            CmnaRecep.AppendChild(doc.CreateTextNode(CmnaRecepd));
            CiudadRecep.AppendChild(doc.CreateTextNode(CiudadRecepd));

        }

        public void docutotal(string MntNetod, string TasaIVAd, string IVAd, string MntTotald)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
        }

        public void docutotaliqui(string MntNetod, string TasaIVAd, string IVAd, string MntTotald, string ValComNetod, string ValComIVAd)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            ValComNetot.AppendChild(doc.CreateTextNode(ValComNetod));
            ValComExet.AppendChild(doc.CreateTextNode("0"));
            ValComIVAt.AppendChild(doc.CreateTextNode(ValComIVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));

        }

        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");


            this.TpoDocLiq = doc.CreateElement("TpoDocLiq");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);
            Detalle.AppendChild(TpoDocLiq);
            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));
            TpoDocLiq.AppendChild(doc.CreateTextNode("33"));
            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }

        public void docucomision(string NroLinComd, string TipoMovimd, string Glosad, string TasaComisiond, string ValComNetod, string ValComExed, string ValComIVAd)
        {
            NroLinCom.AppendChild(doc.CreateTextNode(NroLinComd));
            TipoMovim.AppendChild(doc.CreateTextNode(TipoMovimd));
            Glosa.AppendChild(doc.CreateTextNode(Glosad));
            TasaComision.AppendChild(doc.CreateTextNode(TasaComisiond));
            ValComNeto.AppendChild(doc.CreateTextNode(ValComNetod));
            ValComExe.AppendChild(doc.CreateTextNode(ValComExed));
            ValComIVA.AppendChild(doc.CreateTextNode(ValComIVAd));

        }

        public void docureferencia(string NroLinRefd, string TpoDocRefd, string FolioRefd, string FchRefd, string CodRefd, string RazonRefd)
        {
            docu.AppendChild(Referencia);

            Referencia.AppendChild(NroLinRef);
            Referencia.AppendChild(TpoDocRef);
            Referencia.AppendChild(FolioRef);
            Referencia.AppendChild(FchRef);
            Referencia.AppendChild(CodRef);
            Referencia.AppendChild(RazonRef);

            NroLinRef.AppendChild(doc.CreateTextNode(NroLinRefd));
            TpoDocRef.AppendChild(doc.CreateTextNode(TpoDocRefd));
            FolioRef.AppendChild(doc.CreateTextNode(FolioRefd));
            FchRef.AppendChild(doc.CreateTextNode(FchRefd));
            CodRef.AppendChild(doc.CreateTextNode(CodRefd));
            RazonRef.AppendChild(doc.CreateTextNode(RazonRefd));

        }



        public void docuadjuntos(string Observaciond, string Impresorad, string Copiasd)
        {

            docu.AppendChild(Adjuntos);
            Adjuntos.AppendChild(Observacion);
            Adjuntos.AppendChild(Impresora);
            Adjuntos.AppendChild(Copias);

            Observacion.AppendChild(doc.CreateTextNode(Observaciond));
            Impresora.AppendChild(doc.CreateTextNode(Impresorad));
            Copias.AppendChild(doc.CreateTextNode(Copiasd));
        }
        public void grabal(string nombre)
        {
            string d = "C:\\xml_factura\\";
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
        public void grabal(string nombre, string ruta)
        {
            string d = ruta;
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }


    }


    public class dte_liquidacion_2

    {
        public XmlDocument doc = new XmlDocument();
        private XmlElement docu;
        private XmlElement TipoDTE;
        private XmlElement enca;
        private XmlElement IdDoc;
        private XmlElement Folio;
        private XmlElement FchEmis;
        private XmlElement emisor;
        private XmlElement RUTEmisor;
        private XmlElement RznSoc;
        private XmlElement GiroEmis;
        private XmlElement Acteco;
        private XmlElement DirOrigen;
        private XmlElement CmnaOrigen;
        private XmlElement CiudadOrigen;
        private XmlElement Receptor;
        private XmlElement RUTRecep;
        private XmlElement RznSocRecep;
        private XmlElement GiroRecep;
        private XmlElement DirRecep;
        private XmlElement CmnaRecep;
        private XmlElement CiudadRecep;
        private XmlElement Totales;
        private XmlElement MntNeto;
        private XmlElement TasaIVA;
        private XmlElement IVA;
        private XmlElement MntTotal;

        private XmlElement Detalle;
        private XmlElement NroLinDet;
        private XmlElement CdgItem;
        private XmlElement TpoCodigo;
        private XmlElement VlrCodigo;
        private XmlElement TpoDocLiq;
        private XmlElement NmbItem;
        private XmlElement DscItem;
        private XmlElement QtyItem;
        private XmlElement UnmdItem;
        private XmlElement PrcItem;
        private XmlElement MontoItem;

        private XmlElement Comisiones;
        private XmlElement Comisionest;
        private XmlElement NroLinCom;
        private XmlElement TipoMovim;
        private XmlElement Glosa;
        private XmlElement TasaComision;
        private XmlElement ValComNeto;
        private XmlElement ValComExe;
        private XmlElement ValComIVA;

        private XmlElement ValComNetot;
        private XmlElement ValComExet;
        private XmlElement ValComIVAt;

        private XmlElement Referencia;
        private XmlElement NroLinRef;
        private XmlElement TpoDocRef;
        private XmlElement FolioRef;
        private XmlElement FchRef;
        private XmlElement CodRef;
        private XmlElement RazonRef;



        private XmlElement Adjuntos;
        private XmlElement Observacion;
        private XmlElement Impresora;
        private XmlElement Copias;




        public dte_liquidacion_2()
        {

        }
        public void esquema()
        {

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            this.docu = doc.CreateElement("Liquidacion");
            this.enca = doc.CreateElement("Encabezado");
            this.IdDoc = doc.CreateElement("IdDoc");
            this.TipoDTE = doc.CreateElement("TipoDTE");
            this.Folio = doc.CreateElement("Folio");
            this.FchEmis = doc.CreateElement("FchEmis");

            this.emisor = doc.CreateElement("Emisor");
            this.RUTEmisor = doc.CreateElement("RUTEmisor");
            this.RznSoc = doc.CreateElement("RznSoc");
            this.GiroEmis = doc.CreateElement("GiroEmis");
            this.Acteco = doc.CreateElement("Acteco");
            this.DirOrigen = doc.CreateElement("DirOrigen");
            this.CmnaOrigen = doc.CreateElement("CmnaOrigen");
            this.CiudadOrigen = doc.CreateElement("CiudadOrigen");




            this.Receptor = doc.CreateElement("Receptor");
            this.RUTRecep = doc.CreateElement("RUTRecep");
            this.RznSocRecep = doc.CreateElement("RznSocRecep");
            this.GiroRecep = doc.CreateElement("GiroRecep");
            this.DirRecep = doc.CreateElement("DirRecep");
            this.CmnaRecep = doc.CreateElement("CmnaRecep");
            this.CiudadRecep = doc.CreateElement("CiudadRecep");

            this.Totales = doc.CreateElement("Totales");
            this.MntNeto = doc.CreateElement("MntNeto");
            this.TasaIVA = doc.CreateElement("TasaIVA");
            this.IVA = doc.CreateElement("IVA");
            this.Comisionest = doc.CreateElement("Comisiones");
            this.ValComNetot = doc.CreateElement("ValComNeto");
            this.ValComExet = doc.CreateElement("ValComExe");
            this.ValComIVAt = doc.CreateElement("ValComIVA");
            this.MntTotal = doc.CreateElement("MntTotal");

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");
            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");
            this.TpoDocLiq = doc.CreateElement("TpoDocLiq");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.DscItem = doc.CreateElement("DscItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            this.Comisiones = doc.CreateElement("Comisiones");
            this.NroLinCom = doc.CreateElement("NroLinCom");
            this.TipoMovim = doc.CreateElement("TipoMovim");
            this.Glosa = doc.CreateElement("Glosa");
            this.TasaComision = doc.CreateElement("TasaComision");
            this.ValComNeto = doc.CreateElement("ValComNeto");
            this.ValComExe = doc.CreateElement("ValComExe");
            this.ValComIVA = doc.CreateElement("ValComIVA");



            this.Referencia = doc.CreateElement("Referencia");
            this.NroLinRef = doc.CreateElement("NroLinRef");
            this.TpoDocRef = doc.CreateElement("TpoDocRef");
            this.FolioRef = doc.CreateElement("FolioRef");
            this.FchRef = doc.CreateElement("FchRef");
            this.CodRef = doc.CreateElement("CodRef");
            this.RazonRef = doc.CreateElement("RazonRef");


            this.Adjuntos = doc.CreateElement("Adjuntos");
            this.Observacion = doc.CreateElement("Observacion");
            this.Impresora = doc.CreateElement("Impresora");
            this.Copias = doc.CreateElement("Copias");



            doc.AppendChild(docu);
            docu.AppendChild(enca);

            enca.AppendChild(IdDoc);
            IdDoc.AppendChild(TipoDTE);
            IdDoc.AppendChild(Folio);
            IdDoc.AppendChild(FchEmis);

            enca.AppendChild(emisor);
            emisor.AppendChild(RUTEmisor);
            emisor.AppendChild(RznSoc);
            emisor.AppendChild(Receptor);
            emisor.AppendChild(GiroEmis);
            emisor.AppendChild(Acteco);
            emisor.AppendChild(DirOrigen);
            emisor.AppendChild(CmnaOrigen);
            emisor.AppendChild(CiudadOrigen);


            enca.AppendChild(Receptor);
            Receptor.AppendChild(RUTRecep);
            Receptor.AppendChild(RznSocRecep);
            Receptor.AppendChild(GiroRecep);
            Receptor.AppendChild(DirRecep);
            Receptor.AppendChild(CmnaRecep);
            Receptor.AppendChild(CiudadRecep);




            enca.AppendChild(Totales);
            Totales.AppendChild(MntNeto);
            Totales.AppendChild(TasaIVA);
            Totales.AppendChild(IVA);
            Totales.AppendChild(Comisionest);
            Comisionest.AppendChild(ValComNetot);
            Comisionest.AppendChild(ValComExet);
            Comisionest.AppendChild(ValComIVAt);
            Totales.AppendChild(MntTotal);

            docu.AppendChild(Comisiones);
            Comisiones.AppendChild(NroLinCom);
            Comisiones.AppendChild(TipoMovim);
            Comisiones.AppendChild(Glosa);
            Comisiones.AppendChild(TasaComision);
            Comisiones.AppendChild(ValComNeto);
            Comisiones.AppendChild(ValComExe);
            Comisiones.AppendChild(ValComIVA);





        }
        public void docucabecera(String tipodoc, String folioc, String fechaemi)
        {
            TipoDTE.AppendChild(doc.CreateTextNode(tipodoc));
            Folio.AppendChild(doc.CreateTextNode(folioc));
            FchEmis.AppendChild(doc.CreateTextNode(fechaemi));
        }

        public void docuemisor(String RUTEmisord, String RznSocd, String GiroEmisd, String Actecod, String DirOrigend, String CmnaOrigend, String CiudadOrigend)
        {
            RUTEmisor.AppendChild(doc.CreateTextNode(RUTEmisord));
            RznSoc.AppendChild(doc.CreateTextNode(RznSocd));
            GiroEmis.AppendChild(doc.CreateTextNode(GiroEmisd));
            Acteco.AppendChild(doc.CreateTextNode(Actecod));
            DirOrigen.AppendChild(doc.CreateTextNode(DirOrigend));
            CmnaOrigen.AppendChild(doc.CreateTextNode(CmnaOrigend));
            CiudadOrigen.AppendChild(doc.CreateTextNode(CiudadOrigend));
        }

        public void docureceptor(string RUTRecepd, string RznSocRecepd, string GiroRecepd, string DirRecepd, string CmnaRecepd, string CiudadRecepd)
        {
            RUTRecep.AppendChild(doc.CreateTextNode(RUTRecepd));
            RznSocRecep.AppendChild(doc.CreateTextNode(RznSocRecepd));
            GiroRecep.AppendChild(doc.CreateTextNode(GiroRecepd));
            DirRecep.AppendChild(doc.CreateTextNode(DirRecepd));
            CmnaRecep.AppendChild(doc.CreateTextNode(CmnaRecepd));
            CiudadRecep.AppendChild(doc.CreateTextNode(CiudadRecepd));

        }

        public void docutotal(string MntNetod, string TasaIVAd, string IVAd, string MntTotald)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
        }

        public void docutotaliqui(string MntNetod, string TasaIVAd, string IVAd, string MntTotald, string ValComNetod, string ValComIVAd)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            ValComNetot.AppendChild(doc.CreateTextNode(ValComNetod));
            ValComExet.AppendChild(doc.CreateTextNode("0"));
            ValComIVAt.AppendChild(doc.CreateTextNode(ValComIVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));

        }

        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod,string DscItemd)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");


            this.TpoDocLiq = doc.CreateElement("TpoDocLiq");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.DscItem = doc.CreateElement("DscItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);
            Detalle.AppendChild(TpoDocLiq);
            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(DscItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));
            TpoDocLiq.AppendChild(doc.CreateTextNode("33"));
            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            DscItem.AppendChild(doc.CreateTextNode(DscItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }

        public void docucomision(string NroLinComd, string TipoMovimd, string Glosad, string TasaComisiond, string ValComNetod, string ValComExed, string ValComIVAd)
        {
            NroLinCom.AppendChild(doc.CreateTextNode(NroLinComd));
            TipoMovim.AppendChild(doc.CreateTextNode(TipoMovimd));
            Glosa.AppendChild(doc.CreateTextNode(Glosad));
            TasaComision.AppendChild(doc.CreateTextNode(TasaComisiond));
            ValComNeto.AppendChild(doc.CreateTextNode(ValComNetod));
            ValComExe.AppendChild(doc.CreateTextNode(ValComExed));
            ValComIVA.AppendChild(doc.CreateTextNode(ValComIVAd));

        }

        public void docureferencia(string NroLinRefd, string TpoDocRefd, string FolioRefd, string FchRefd, string CodRefd, string RazonRefd)
        {
            docu.AppendChild(Referencia);

            Referencia.AppendChild(NroLinRef);
            Referencia.AppendChild(TpoDocRef);
            Referencia.AppendChild(FolioRef);
            Referencia.AppendChild(FchRef);
            Referencia.AppendChild(CodRef);
            Referencia.AppendChild(RazonRef);

            NroLinRef.AppendChild(doc.CreateTextNode(NroLinRefd));
            TpoDocRef.AppendChild(doc.CreateTextNode(TpoDocRefd));
            FolioRef.AppendChild(doc.CreateTextNode(FolioRefd));
            FchRef.AppendChild(doc.CreateTextNode(FchRefd));
            CodRef.AppendChild(doc.CreateTextNode(CodRefd));
            RazonRef.AppendChild(doc.CreateTextNode(RazonRefd));

        }



        public void docuadjuntos(string Observaciond, string Impresorad, string Copiasd)
        {

            docu.AppendChild(Adjuntos);
            Adjuntos.AppendChild(Observacion);
            Adjuntos.AppendChild(Impresora);
            Adjuntos.AppendChild(Copias);

            Observacion.AppendChild(doc.CreateTextNode(Observaciond));
            Impresora.AppendChild(doc.CreateTextNode(Impresorad));
            Copias.AppendChild(doc.CreateTextNode(Copiasd));
        }
        public void grabal(string nombre)
        {
            string d = "C:\\xml_factura\\";
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
        public void grabal(string nombre, string ruta)
        {
            string d = ruta;
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }


    }

    public class dte_notacredito
    {
        public XmlDocument doc = new XmlDocument();
        private XmlElement docu;
        private XmlElement TipoDTE;
        private XmlElement enca;
        private XmlElement IdDoc;
        private XmlElement Folio;
        private XmlElement FchEmis;
        private XmlElement emisor;
        private XmlElement RUTEmisor;
        private XmlElement RznSoc;
        private XmlElement GiroEmis;
        private XmlElement Acteco;
        private XmlElement DirOrigen;
        private XmlElement CmnaOrigen;
        private XmlElement CiudadOrigen;
        private XmlElement Receptor;
        private XmlElement RUTRecep;
        private XmlElement RznSocRecep;
        private XmlElement GiroRecep;
        private XmlElement DirRecep;
        private XmlElement CmnaRecep;
        private XmlElement CiudadRecep;
        private XmlElement Totales;
        private XmlElement MntNeto;
        private XmlElement TasaIVA;
        private XmlElement IVA;
        private XmlElement MntTotal;






        private XmlElement Detalle;
        private XmlElement CdgItem;
        private XmlElement TpoCodigo;
        private XmlElement VlrCodigo;
        private XmlElement NroLinDet;
        private XmlElement NmbItem;
        private XmlElement QtyItem;
        private XmlElement UnmdItem;
        private XmlElement PrcItem;
        private XmlElement MontoItem;

        private XmlElement Referencia;
        private XmlElement NroLinRef;
        private XmlElement TpoDocRef;
        private XmlElement FolioRef;
        private XmlElement FchRef;
        private XmlElement CodRef;
        private XmlElement RazonRef;






        private XmlElement Adjuntos;
        private XmlElement Observacion;
        private XmlElement Impresora;
        private XmlElement Copias;

        public dte_notacredito()
        {

        }
        public void esquema()
        {

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            this.docu = doc.CreateElement("Documento");
            this.enca = doc.CreateElement("Encabezado");
            this.IdDoc = doc.CreateElement("IdDoc");
            this.TipoDTE = doc.CreateElement("TipoDTE");
            this.Folio = doc.CreateElement("Folio");
            this.FchEmis = doc.CreateElement("FchEmis");

            this.emisor = doc.CreateElement("Emisor");
            this.RUTEmisor = doc.CreateElement("RUTEmisor");
            this.RznSoc = doc.CreateElement("RznSoc");
            this.GiroEmis = doc.CreateElement("GiroEmis");
            this.Acteco = doc.CreateElement("Acteco");
            this.DirOrigen = doc.CreateElement("DirOrigen");
            this.CmnaOrigen = doc.CreateElement("CmnaOrigen");
            this.CiudadOrigen = doc.CreateElement("CiudadOrigen");




            this.Receptor = doc.CreateElement("Receptor");
            this.RUTRecep = doc.CreateElement("RUTRecep");
            this.RznSocRecep = doc.CreateElement("RznSocRecep");
            this.GiroRecep = doc.CreateElement("GiroRecep");
            this.DirRecep = doc.CreateElement("DirRecep");
            this.CmnaRecep = doc.CreateElement("CmnaRecep");
            this.CiudadRecep = doc.CreateElement("CiudadRecep");

            this.Totales = doc.CreateElement("Totales");
            this.MntNeto = doc.CreateElement("MntNeto");
            this.TasaIVA = doc.CreateElement("TasaIVA");
            this.IVA = doc.CreateElement("IVA");
            this.MntTotal = doc.CreateElement("MntTotal");

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            this.Referencia = doc.CreateElement("Referencia");
            this.NroLinRef = doc.CreateElement("NroLinRef");
            this.TpoDocRef = doc.CreateElement("TpoDocRef");
            this.FolioRef = doc.CreateElement("FolioRef");
            this.FchRef = doc.CreateElement("FchRef");
            this.CodRef = doc.CreateElement("CodRef");
            this.RazonRef = doc.CreateElement("RazonRef");



            this.Adjuntos = doc.CreateElement("Adjuntos");
            this.Observacion = doc.CreateElement("Observacion");
            this.Impresora = doc.CreateElement("Impresora");
            this.Copias = doc.CreateElement("Copias");



            doc.AppendChild(docu);
            docu.AppendChild(enca);

            enca.AppendChild(IdDoc);
            IdDoc.AppendChild(TipoDTE);
            IdDoc.AppendChild(Folio);
            IdDoc.AppendChild(FchEmis);

            enca.AppendChild(emisor);
            emisor.AppendChild(RUTEmisor);
            emisor.AppendChild(RznSoc);
            emisor.AppendChild(Receptor);
            emisor.AppendChild(GiroEmis);
            emisor.AppendChild(Acteco);
            emisor.AppendChild(DirOrigen);
            emisor.AppendChild(CmnaOrigen);
            emisor.AppendChild(CiudadOrigen);


            enca.AppendChild(Receptor);
            Receptor.AppendChild(RUTRecep);
            Receptor.AppendChild(RznSocRecep);
            Receptor.AppendChild(GiroRecep);
            Receptor.AppendChild(DirRecep);
            Receptor.AppendChild(CmnaRecep);
            Receptor.AppendChild(CiudadRecep);


            enca.AppendChild(Totales);
            Totales.AppendChild(MntNeto);
            Totales.AppendChild(TasaIVA);
            Totales.AppendChild(IVA);
            Totales.AppendChild(MntTotal);





        }

        public void docucabecera(String tipodoc, String folioc, String fechaemi)
        {
            TipoDTE.AppendChild(doc.CreateTextNode(tipodoc));
            Folio.AppendChild(doc.CreateTextNode(folioc));
            FchEmis.AppendChild(doc.CreateTextNode(fechaemi));
        }

        public void docuemisor(String RUTEmisord, String RznSocd, String GiroEmisd, String Actecod, String DirOrigend, String CmnaOrigend, String CiudadOrigend)
        {
            RUTEmisor.AppendChild(doc.CreateTextNode(RUTEmisord));
            RznSoc.AppendChild(doc.CreateTextNode(RznSocd));
            GiroEmis.AppendChild(doc.CreateTextNode(GiroEmisd));
            Acteco.AppendChild(doc.CreateTextNode(Actecod));
            DirOrigen.AppendChild(doc.CreateTextNode(DirOrigend));
            CmnaOrigen.AppendChild(doc.CreateTextNode(CmnaOrigend));
            CiudadOrigen.AppendChild(doc.CreateTextNode(CiudadOrigend));
        }

        public void docureceptor(string RUTRecepd, string RznSocRecepd, string GiroRecepd, string DirRecepd, string CmnaRecepd, string CiudadRecepd)
        {
            RUTRecep.AppendChild(doc.CreateTextNode(RUTRecepd));
            RznSocRecep.AppendChild(doc.CreateTextNode(RznSocRecepd));
            GiroRecep.AppendChild(doc.CreateTextNode(GiroRecepd));
            DirRecep.AppendChild(doc.CreateTextNode(DirRecepd));
            CmnaRecep.AppendChild(doc.CreateTextNode(CmnaRecepd));
            CiudadRecep.AppendChild(doc.CreateTextNode(CiudadRecepd));

        }

        public void docutotal(string MntNetod, string TasaIVAd, string IVAd, string MntTotald)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
        }


        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);

            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));

            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }

        public void docureferencia(string NroLinRefd, string TpoDocRefd, string FolioRefd, string FchRefd, string CodRefd, string RazonRefd)
        {
            docu.AppendChild(Referencia);

            Referencia.AppendChild(NroLinRef);
            Referencia.AppendChild(TpoDocRef);
            Referencia.AppendChild(FolioRef);
            Referencia.AppendChild(FchRef);
            Referencia.AppendChild(CodRef);
            Referencia.AppendChild(RazonRef);

            NroLinRef.AppendChild(doc.CreateTextNode(NroLinRefd));
            TpoDocRef.AppendChild(doc.CreateTextNode(TpoDocRefd));
            FolioRef.AppendChild(doc.CreateTextNode(FolioRefd));
            FchRef.AppendChild(doc.CreateTextNode(FchRefd));
            CodRef.AppendChild(doc.CreateTextNode(CodRefd));
            RazonRef.AppendChild(doc.CreateTextNode(RazonRefd));

        }


        public void docuadjuntos(string Observaciond, string Impresorad, string Copiasd)
        {
            docu.AppendChild(Adjuntos);
            Adjuntos.AppendChild(Observacion);
            Adjuntos.AppendChild(Impresora);
            Adjuntos.AppendChild(Copias);

            Observacion.AppendChild(doc.CreateTextNode(Observaciond));
            Impresora.AppendChild(doc.CreateTextNode(Impresorad));
            Copias.AppendChild(doc.CreateTextNode(Copiasd));
        }
        public void graba(string nombre)
        {
            string d = "C:\\xml_factura\\";
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
        public void graba(string nombre, string ruta)
        {
            string d = ruta;
            d = string.Concat(d, nombre, ".xml");
            try
            {
                doc.Save(d);
            }
            catch
            {
            }
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
    }


    public class dte_guiadespacho
    {
        public XmlDocument doc = new XmlDocument();
        private XmlElement docu;
        private XmlElement TipoDTE;
        private XmlElement enca;
        private XmlElement IdDoc;
        private XmlElement Folio;
        private XmlElement FchEmis;
        private XmlElement emisor;
        private XmlElement RUTEmisor;
        private XmlElement RznSoc;
        private XmlElement GiroEmis;
        private XmlElement Acteco;

        private XmlElement GuiaExport;
        private XmlElement CdgTraslado;
        private XmlElement DirOrigen;


        private XmlElement CmnaOrigen;
        private XmlElement CiudadOrigen;
        private XmlElement Receptor;
        private XmlElement RUTRecep;
        private XmlElement RznSocRecep;
        private XmlElement GiroRecep;
        private XmlElement DirRecep;
        private XmlElement CmnaRecep;
        private XmlElement CiudadRecep;

        private XmlElement Transporte;
        private XmlElement Patente;
        private XmlElement RUTTrans;
        private XmlElement DirDest;
        private XmlElement CmnaDest;
        private XmlElement CiudadDest;

        private XmlElement Totales;
        private XmlElement MntNeto;
        private XmlElement MntExe;
        private XmlElement TasaIVA;
        private XmlElement IVA;
        private XmlElement MntTotal;






        private XmlElement Detalle;
        private XmlElement CdgItem;
        private XmlElement TpoCodigo;
        private XmlElement VlrCodigo;
        private XmlElement NroLinDet;
        private XmlElement NmbItem;
        private XmlElement QtyItem;
        private XmlElement UnmdItem;
        private XmlElement PrcItem;
        private XmlElement MontoItem;

        private XmlElement Referencia;
        private XmlElement NroLinRef;
        private XmlElement TpoDocRef;
        private XmlElement FolioRef;
        private XmlElement FchRef;
        private XmlElement CodRef;
        private XmlElement RazonRef;






        private XmlElement Adjuntos;
        private XmlElement Observacion;
        private XmlElement Impresora;
        private XmlElement Copias;

        public dte_guiadespacho()
        {

        }
        public void esquema()
        {

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            this.docu = doc.CreateElement("Documento");
            this.enca = doc.CreateElement("Encabezado");
            this.IdDoc = doc.CreateElement("IdDoc");
            this.TipoDTE = doc.CreateElement("TipoDTE");
            this.Folio = doc.CreateElement("Folio");
            this.FchEmis = doc.CreateElement("FchEmis");

            this.emisor = doc.CreateElement("Emisor");
            this.RUTEmisor = doc.CreateElement("RUTEmisor");
            this.RznSoc = doc.CreateElement("RznSoc");
            this.GiroEmis = doc.CreateElement("GiroEmis");
            this.Acteco = doc.CreateElement("Acteco");
            this.GuiaExport = doc.CreateElement("GuiaExport");
            this.CdgTraslado = doc.CreateElement("CdgTraslado");


            this.DirOrigen = doc.CreateElement("DirOrigen");
            this.CmnaOrigen = doc.CreateElement("CmnaOrigen");
            this.CiudadOrigen = doc.CreateElement("CiudadOrigen");




            this.Receptor = doc.CreateElement("Receptor");
            this.RUTRecep = doc.CreateElement("RUTRecep");
            this.RznSocRecep = doc.CreateElement("RznSocRecep");
            this.GiroRecep = doc.CreateElement("GiroRecep");
            this.DirRecep = doc.CreateElement("DirRecep");
            this.CmnaRecep = doc.CreateElement("CmnaRecep");
            this.CiudadRecep = doc.CreateElement("CiudadRecep");

            this.Transporte = doc.CreateElement("Transporte");
            this.Patente = doc.CreateElement("Patente");
            this.RUTTrans = doc.CreateElement("RUTTrans");
            this.DirDest = doc.CreateElement("DirDest");
            this.CmnaDest = doc.CreateElement("CmnDest");
            this.CiudadDest = doc.CreateElement("CiudadDest");


            this.Totales = doc.CreateElement("Totales");
            this.MntNeto = doc.CreateElement("MntNeto");
            this.MntExe = doc.CreateElement("MntExe");
            this.TasaIVA = doc.CreateElement("TasaIVA");
            this.IVA = doc.CreateElement("IVA");
            this.MntTotal = doc.CreateElement("MntTotal");

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            this.Referencia = doc.CreateElement("Referencia");
            this.NroLinRef = doc.CreateElement("NroLinRef");
            this.TpoDocRef = doc.CreateElement("TpoDocRef");
            this.FolioRef = doc.CreateElement("FolioRef");
            this.FchRef = doc.CreateElement("FchRef");
            this.CodRef = doc.CreateElement("CodRef");
            this.RazonRef = doc.CreateElement("RazonRef");



            this.Adjuntos = doc.CreateElement("Adjuntos");
            this.Observacion = doc.CreateElement("Observacion");
            this.Impresora = doc.CreateElement("Impresora");
            this.Copias = doc.CreateElement("Copias");



            doc.AppendChild(docu);
            docu.AppendChild(enca);

            enca.AppendChild(IdDoc);
            IdDoc.AppendChild(TipoDTE);
            IdDoc.AppendChild(Folio);
            IdDoc.AppendChild(FchEmis);

            enca.AppendChild(emisor);
            emisor.AppendChild(RUTEmisor);
            emisor.AppendChild(RznSoc);
            emisor.AppendChild(Receptor);
            emisor.AppendChild(GiroEmis);
            emisor.AppendChild(Acteco);
            emisor.AppendChild(GuiaExport);
            GuiaExport.AppendChild(CdgTraslado);
            emisor.AppendChild(DirOrigen);
            emisor.AppendChild(CmnaOrigen);
            emisor.AppendChild(CiudadOrigen);


            enca.AppendChild(Receptor);
            Receptor.AppendChild(RUTRecep);
            Receptor.AppendChild(RznSocRecep);
            Receptor.AppendChild(GiroRecep);
            Receptor.AppendChild(DirRecep);
            Receptor.AppendChild(CmnaRecep);
            Receptor.AppendChild(CiudadRecep);

            enca.AppendChild(Transporte);
            Transporte.AppendChild(Patente);
            Transporte.AppendChild(RUTTrans);
            Transporte.AppendChild(DirDest);
            Transporte.AppendChild(CmnaDest);
            Transporte.AppendChild(CiudadDest);



            enca.AppendChild(Totales);
            Totales.AppendChild(MntNeto);
            Totales.AppendChild(MntExe);
            Totales.AppendChild(TasaIVA);
            Totales.AppendChild(IVA);
            Totales.AppendChild(MntTotal);





        }

        public void docucabecera(String tipodoc, String folioc, String fechaemi)
        {
            String tipo = "52";
            TipoDTE.AppendChild(doc.CreateTextNode(tipo));
            Folio.AppendChild(doc.CreateTextNode(folioc));
            FchEmis.AppendChild(doc.CreateTextNode(fechaemi));
        }

        public void docuemisor(String RUTEmisord, String RznSocd, String GiroEmisd, String Actecod, String DirOrigend, String CmnaOrigend, String CiudadOrigend)
        {
            RUTEmisor.AppendChild(doc.CreateTextNode(RUTEmisord));
            RznSoc.AppendChild(doc.CreateTextNode(RznSocd));
            GiroEmis.AppendChild(doc.CreateTextNode(GiroEmisd));
            Acteco.AppendChild(doc.CreateTextNode(Actecod));
            CdgTraslado.AppendChild(doc.CreateElement("3"));


            DirOrigen.AppendChild(doc.CreateTextNode(DirOrigend));
            CmnaOrigen.AppendChild(doc.CreateTextNode(CmnaOrigend));
            CiudadOrigen.AppendChild(doc.CreateTextNode(CiudadOrigend));
        }

        public void docureceptor(string RUTRecepd, string RznSocRecepd, string GiroRecepd, string DirRecepd, string CmnaRecepd, string CiudadRecepd)
        {
            RUTRecep.AppendChild(doc.CreateTextNode(RUTRecepd));
            RznSocRecep.AppendChild(doc.CreateTextNode(RznSocRecepd));
            GiroRecep.AppendChild(doc.CreateTextNode(GiroRecepd));
            DirRecep.AppendChild(doc.CreateTextNode(DirRecepd));
            CmnaRecep.AppendChild(doc.CreateTextNode(CmnaRecepd));
            CiudadRecep.AppendChild(doc.CreateTextNode(CiudadRecepd));

        }

        public void docutranspote(String Patented, String RUTTransd, String DirDestd, String CmnaDestd, String CiudadDestd)
        {
            Patente.AppendChild(doc.CreateTextNode(Patented));
            RUTTrans.AppendChild(doc.CreateTextNode(RUTTransd));
            DirDest.AppendChild(doc.CreateTextNode(DirDestd));
            CmnaDest.AppendChild(doc.CreateTextNode(CmnaDestd));
            CiudadDest.AppendChild(doc.CreateTextNode(CiudadDestd));
        }

        public void docutotal(string MntNetod, string TasaIVAd, string IVAd, string MntTotald)
        {
            MntNeto.AppendChild(doc.CreateTextNode(MntNetod));
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            IVA.AppendChild(doc.CreateTextNode(IVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
        }

        public void docutotal(string TasaIVAd, string MntTotald)
        {
            TasaIVA.AppendChild(doc.CreateTextNode(TasaIVAd));
            MntTotal.AppendChild(doc.CreateTextNode(MntTotald));
        }

        public void docudetalle(string NroLinDetd, string NmbItemd, string QtyItemd, string UnmdItemd, string PrcItemd, string MontoItemd, string TpoCodigod, string VlrCodigod)
        {

            this.Detalle = doc.CreateElement("Detalle");
            this.NroLinDet = doc.CreateElement("NroLinDet");

            this.CdgItem = doc.CreateElement("CdgItem");
            this.TpoCodigo = doc.CreateElement("TpoCodigo");
            this.VlrCodigo = doc.CreateElement("VlrCodigo");
            this.NmbItem = doc.CreateElement("NmbItem");
            this.QtyItem = doc.CreateElement("QtyItem");
            this.UnmdItem = doc.CreateElement("UnmdItem");
            this.PrcItem = doc.CreateElement("PrcItem");
            this.MontoItem = doc.CreateElement("MontoItem");

            docu.AppendChild(Detalle);

            Detalle.AppendChild(NroLinDet);
            Detalle.AppendChild(CdgItem);
            CdgItem.AppendChild(TpoCodigo);
            CdgItem.AppendChild(VlrCodigo);

            Detalle.AppendChild(NmbItem);
            Detalle.AppendChild(QtyItem);
            Detalle.AppendChild(UnmdItem);
            Detalle.AppendChild(PrcItem);
            Detalle.AppendChild(MontoItem);


            NroLinDet.AppendChild(doc.CreateTextNode(NroLinDetd));
            //CdgItem.AppendChild(doc.CreateTextNode(CdgItemd));
            TpoCodigo.AppendChild(doc.CreateTextNode(TpoCodigod));
            VlrCodigo.AppendChild(doc.CreateTextNode(VlrCodigod.TrimStart()));

            NmbItem.AppendChild(doc.CreateTextNode(NmbItemd));
            QtyItem.AppendChild(doc.CreateTextNode(QtyItemd));
            UnmdItem.AppendChild(doc.CreateTextNode(UnmdItemd));
            PrcItem.AppendChild(doc.CreateTextNode(PrcItemd));
            MontoItem.AppendChild(doc.CreateTextNode(MontoItemd));


        }




        public void docuadjuntos(string Impresorad, string Copiasd)
        {
            docu.AppendChild(Adjuntos);

            Adjuntos.AppendChild(Impresora);
            Adjuntos.AppendChild(Copias);


            Impresora.AppendChild(doc.CreateTextNode(Impresorad));
            Copias.AppendChild(doc.CreateTextNode(Copiasd));
        }
        public void graba(string nombre)
        {
            string d = "C:\\xml_factura\\";
            d = string.Concat(d, nombre, ".xml");
            doc.Save(d);
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
        public void graba(string nombre, string ruta)
        {
            string d = ruta;
            d = string.Concat(d, nombre, ".xml");
            try
            {
                doc.Save(d);
            }
            catch
            {
            }
            //doc.Save("C:\\xml_factura\\prueba2.xml");
        }
    }
}
