using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BarcodeGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            firstComboBox.SelectedIndex = 0;
            secondComboBox.SelectedIndex = 0;
            MaximizeBox = false;
            toolTip.SetToolTip(firstComboBox, "RA-RZ — регистрируемое отправление письменной корреспонденции (заказная карточка, письмо, бандероль, мелкий пакет (до 2 кг),\n" +
                                                        "заказной мешок «М» — международное отправление с большим объемом печатной продукции: бумагами, книгами, журналами);\n" +
                                                        "LA - LZ — отслеживаемое письмо, несколько подтипов; использование LZ требует двустороннего соглашения\n" +
                                                        "VA - VZ — письмо с объявленной ценностью;\n" +
                                                        "CA - CZ — международная посылка(более 2 кг);\n" +
                                                        "EA - EZ — экспресс - отправления(EMS от Express Mail Service);\n" +
                                                        "UA - UZ — нерегистрируемые и неотслеживаемые отправления, которые обязаны проходить таможенные процедуры;\n" +
                                                        "ZA - ZZ — SRM - отправление(от simplified registered mail), простой регистрируемый пакет.");
            toolTip.SetToolTip(secondComboBox, "Двухбуквенный код ISO страны");
            toolTip.SetToolTip(rpoShiButton, "Сгенерировать ШИ РПО");
            toolTip.SetToolTip(waybillShiButton, "Сгенерировать ШИ накладной (ф.16/ф.23)");
            toolTip.SetToolTip(interShiButton, "Сгенерировать ШИ международного формата (RA*********RU)");
            Text = "Генератор ШПИ";

        }

        private void Form1_Load(object sender, EventArgs e) { }


        private void CleanButton_Click(object sender, EventArgs e)
        {
            historyBox.Text = String.Empty;
            rpoNumeric.Value = 1;
            interShiNumeric.Value = 1;
            waybillNumeric.Value = 1;
            indexComboBox.Focus();
        }

        private void HistoryBox_TextChanged(object sender, EventArgs e)
        {
            historyBox.SelectionStart = historyBox.Text.Length;
            historyBox.ScrollToCaret();
        }

        private void RpoBarcode_Click(object sender, EventArgs e)
        {
            if (indexComboBox.Text.Length == 6)
            {
                var index = indexComboBox.Text;
                Barcode barcode = new Barcode(index, false, (int)rpoNumeric.Value);
                historyBox.Text += "ШПИ РПО" + Environment.NewLine;             
                WriteHistory(barcode.ShiRpo);
            }
        }

        private void WaybillBarcodeButton_Click(object sender, EventArgs e)
        {
            if (indexComboBox.Text.Length == 6)
            {
                var index = indexComboBox.Text;
                Barcode barcode = new Barcode(index, true, (int)waybillNumeric.Value);
                historyBox.Text += "ШИ Ф.16/23" + Environment.NewLine;
                WriteHistory(barcode.ShiRpo);
            }
        }

        private void InterBarcodeButton_Click(object sender, EventArgs e)
        {
            if (firstComboBox.Text.Length == 2 && secondComboBox.Text.Length == 2)
            {
                var barcode = new Barcode(firstComboBox.Text, secondComboBox.Text, (int)interShiNumeric.Value);
                historyBox.Text += "ШИ междунар." + Environment.NewLine;
                WriteHistory(barcode.ShiRpo);
            }
        }

        private void WriteHistory(List<string> barcodes)
        {
            var toHistory = String.Empty;
            foreach (string barcode in barcodes)
            {
                toHistory += barcode + Environment.NewLine;
            }
            toHistory += Environment.NewLine;
            historyBox.Text += toHistory;
        }

        
    }
}
