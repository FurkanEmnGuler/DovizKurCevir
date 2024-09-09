using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizKurCevir
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtValue.Text, out double value))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
                return;
            }

            string selectedCurrency = rbTL.Checked ? "TRY" : rbEURO.Checked ? "EUR" : rbUSD.Checked ? "USD" : null;

            if (selectedCurrency == null)
            {
                MessageBox.Show("Geçerli bir butona basınız.");
                return;
            }

            // Dünkü tarihi hesapla
            DateTime yesterday = DateTime.Today.AddDays(-1);
            string url = $"https://www.tcmb.gov.tr/kurlar/{yesterday:yyyyMM}/{yesterday:ddMMyyyy}.xml";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string xmlData = client.DownloadString(url);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(xmlData);

                    var usdRateNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='USD']/ForexSelling");
                    var eurRateNode = xmlDoc.SelectSingleNode("//Currency[@CurrencyCode='EUR']/ForexSelling");

                    if (usdRateNode == null || eurRateNode == null)
                    {
                        MessageBox.Show("Döviz kuru bilgileri alınamadı.");
                        return;
                    }

                    double usdRate = double.Parse(usdRateNode.InnerText, CultureInfo.InvariantCulture);
                    double eurRate = double.Parse(eurRateNode.InnerText, CultureInfo.InvariantCulture);

                    txtResult.Clear();

                    switch (selectedCurrency)
                    {
                        case "EUR":
                            txtResult.Text = $"USD: {(value * (eurRate / usdRate)).ToString("F2", CultureInfo.InvariantCulture)}{Environment.NewLine}";
                            txtResult.Text += $"TRY: {(value * eurRate).ToString("F2", CultureInfo.InvariantCulture)}{Environment.NewLine}";
                            break;
                        case "USD":
                            txtResult.Text = $"EURO: {(value * (usdRate / eurRate)).ToString("F2", CultureInfo.InvariantCulture)}{Environment.NewLine}"; // Değiştirildi
                            txtResult.Text += $"TRY: {(value * usdRate).ToString("F2", CultureInfo.InvariantCulture)}{Environment.NewLine}";
                            break;
                        case "TRY":
                            txtResult.Text = $"USD: {(value / usdRate).ToString("F2", CultureInfo.InvariantCulture)}{Environment.NewLine}";
                            txtResult.Text += $"EURO: {(value / eurRate).ToString("F2", CultureInfo.InvariantCulture)}{Environment.NewLine}";
                            break;
                    }
                }
            }
            catch (WebException webEx)
            {
                MessageBox.Show("İnternet bağlantı hatası: " + webEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
    //    double value;
    //    if (!double.TryParse(txtValue.Text, out value))
    //    {
    //        MessageBox.Show("Lütfen geçerli bir sayı girin.");
    //        return;
    //    }

    //string selectedCurrency = "";

    //if (rbTL.Checked)
    //{
    //    selectedCurrency = "TRY";
    //}
    //else if (rbEURO.Checked)
    //{
    //    selectedCurrency = "EUR";
    //}
    //else if (rbUSD.Checked)
    //{
    //    selectedCurrency = "USD";
    //}
    //else
    //{
    //    MessageBox.Show("Geçerli bir butona basınız.");
    //    return;
    //}

    //string url = "https://www.tcmb.gov.tr/kurlar/today.xml";

    //try
    //{
    //    using (WebClient client = new WebClient())
    //    {
    //        string xmlData = client.DownloadString(url);

    //        XmlDocument xmlDoc = new XmlDocument();
    //        xmlDoc.LoadXml(xmlData);

    //        XmlNodeList currencyList = xmlDoc.GetElementsByTagName("Currency");

    //        txtResult.Text = ""; // Önceki sonuçları temizle
    //        double usdRate = 0, eurRate = 0;

    //        foreach (XmlNode currency in currencyList)
    //        {
    //            string currencyCode = currency.Attributes["CurrencyCode"].InnerText;
    //            string currencyValue = currency.SelectSingleNode("ForexSelling").InnerText;

    //            if (string.IsNullOrEmpty(currencyValue)) continue;

    //            double exchangeRate = double.Parse(currencyValue, CultureInfo.InvariantCulture);

    //            if (currencyCode == "USD")
    //            {
    //                usdRate = exchangeRate;
    //            }
    //            else if (currencyCode == "EUR")
    //            {
    //                eurRate = exchangeRate;
    //            }
    //        }
    //        Euro'yu Dolar'a ve Türk Lirası'na çevirme işlemi
    //        if (selectedCurrency == "EUR")
    //        {
    //            double euroToUsd = value * (usdRate / eurRate);
    //            txtResult.Text += $"USD: {euroToUsd.ToString("F2")}{Environment.NewLine}";

    //            double euroToTry = value * eurRate;
    //            txtResult.Text += $"TRY: {euroToTry.ToString("F2")}{Environment.NewLine}";
    //        }
    //        Dolar'ı Euro'ya ve Türk Lirası'na çevirme işlemi
    //        else if (selectedCurrency == "USD")
    //        {
    //            double usdToEuro = value * (eurRate / usdRate);
    //            txtResult.Text += $"EURO: {usdToEuro.ToString("F2")}{Environment.NewLine}";

    //            double usdToTry = value * usdRate;
    //            txtResult.Text += $"TRY: {usdToTry.ToString("F2")}{Environment.NewLine}";
    //        }
    //        Türk Lirası'nı Dolar'a ve Euro'ya çevirme işlemi
    //        else if (selectedCurrency == "TRY")
    //        {
    //            double tlToUsd = value / usdRate;
    //            txtResult.Text += $"USD: {tlToUsd.ToString("F2")}{Environment.NewLine}";

    //            double tlToEuro = value / eurRate;
    //            txtResult.Text += $"EURO: {tlToEuro.ToString("F2")}{Environment.NewLine}";
    //        }
    //    }
    //}
    //catch (Exception ex)
    //{
    //    MessageBox.Show("Bir hata oluştu: " + ex.Message);
    //}
}