using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GoodsPriceApp
{
    public partial class TestMainForm : Form
    {
        public TestMainForm()
        {
            InitializeComponent();
        }

        public class TextBoxEx : TextBox
        {
            public String PlaceHolderStr { get; set; }
            protected override void OnPaint(PaintEventArgs e)
            {
                if (!String.IsNullOrEmpty(this.PlaceHolderStr))
                {
                    e.Graphics.DrawString(this.PlaceHolderStr, this.Font, new SolidBrush(Color.LightGray), 0, 0);
                }
                else
                {
                    base.OnPaint(e);
                }
            }
        }

        public enum goodsNature
        {
            /// <summary>
            /// 进口
            /// </summary>
            import = 1,
            /// <summary>
            /// 本地产
            /// </summary>
            local = 2
        }

        public enum goodsTaxNaure
        {
            /// <summary>
            /// 不收基础税率
            /// </summary>
            None = 1,
            /// <summary>
            /// 收基础税率
            /// </summary>
            Tax = 2
        }

        public class goodsBaseInfor
        {
            public string name { get; set; }

            public double price { get; set; }

            public goodsNature nature { get; set; }

            public goodsTaxNaure taxNaure { get; set; }
        }

        public  Dictionary<int, List<goodsBaseInfor>> dic = new Dictionary<int, List<goodsBaseInfor>>();


        private double calculationPrice(goodsBaseInfor basegood, out double tax)
        {
            tax = 0;
            if (basegood.nature == goodsNature.import)
            {
                tax += Math.Round(basegood.price * 0.05, 2);
            }
            if (basegood.taxNaure == goodsTaxNaure.Tax)
            {
                tax += Math.Round((basegood.price) * 0.10, 2);
            }
            double sellPrice = basegood.price + tax;
            return sellPrice;
        }

        /// <summary>
        /// window load event 
        /// </summary>
        private void TestMainForm_Load(object sender, EventArgs e)
        {
            //init goods infor

            List<goodsBaseInfor> typeKeyAList = new List<goodsBaseInfor>();
            typeKeyAList.Add(new goodsBaseInfor() { name = "1book", price = 12.49, nature = goodsNature.local, taxNaure = goodsTaxNaure.None });
            typeKeyAList.Add(new goodsBaseInfor() { name = "1张音乐光碟", price = 14.99, nature = goodsNature.local, taxNaure = goodsTaxNaure.Tax });
            typeKeyAList.Add(new goodsBaseInfor() { name = "1块巧克力", price = 0.85, nature = goodsNature.local, taxNaure = goodsTaxNaure.None });
            dic.Add(1, typeKeyAList);

            List<goodsBaseInfor> typeKeyBList = new List<goodsBaseInfor>();
            typeKeyBList.Add(new goodsBaseInfor() { name = "一盒巧克力", price = 10.00, nature = goodsNature.import, taxNaure = goodsTaxNaure.None });
            typeKeyBList.Add(new goodsBaseInfor() { name = "一瓶香水", price = 47.50, nature = goodsNature.import, taxNaure = goodsTaxNaure.Tax });
            dic.Add(2, typeKeyBList);

            List<goodsBaseInfor> typeKeyCList = new List<goodsBaseInfor>();
            typeKeyCList.Add(new goodsBaseInfor() { name = "一瓶香水", price = 27.99, nature = goodsNature.import, taxNaure = goodsTaxNaure.Tax });
            typeKeyCList.Add(new goodsBaseInfor() { name = "一瓶香水", price = 18.99, nature = goodsNature.local, taxNaure = goodsTaxNaure.Tax });
            typeKeyCList.Add(new goodsBaseInfor() { name = "一包头痛药", price = 9.75, nature = goodsNature.local, taxNaure = goodsTaxNaure.None });
            typeKeyCList.Add(new goodsBaseInfor() { name = "一盒巧克力", price = 11.25, nature = goodsNature.import, taxNaure = goodsTaxNaure.None });
            dic.Add(3, typeKeyCList);
        }

        /// <summary>
        /// get goods details
        /// </summary>
        private void btn_Click(object sender, EventArgs e)
        {
            txt_output.Text = string.Empty;
            string _inputPrice = txt_input.Text.Trim();
            if (_inputPrice == "1" || _inputPrice == "2" || _inputPrice == "3")
            {
                double allSellTax = 0;
                double totalPrice = 0;
                string outPutMessage = string.Empty;
                List<goodsBaseInfor> goodList = dic[Convert.ToInt32(_inputPrice)];
                foreach (goodsBaseInfor baseModel in goodList)
                {
                    double Tax = 0;
                    double sellPrice = calculationPrice(baseModel, out Tax);
                    totalPrice += sellPrice;
                    allSellTax += Tax;
                    outPutMessage += baseModel.name + ":" + sellPrice.ToString("0.00") + "\r\n";
                }
                outPutMessage += "销售税："+ allSellTax.ToString("0.00") + "\r\n";
                outPutMessage += "共计：" + totalPrice.ToString("0.00");
                txt_output.Text = outPutMessage;
            }
            else
            {
                MessageBox.Show("暂没商品价格");
            }
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            txt_output.Text = string.Empty;
            txt_show.Text = string.Empty;
            string _inputPrice = txt_input.Text.Trim();
            if (_inputPrice == "1" || _inputPrice == "2" || _inputPrice == "3")
            {
                string intPutMessage = string.Empty;
                List<goodsBaseInfor> goodList = dic[Convert.ToInt32(_inputPrice)];
                foreach (goodsBaseInfor baseModel in goodList)
                {
                    intPutMessage += baseModel.name + ":" + baseModel.price + "\r\n";
                }
                txt_show.Text = intPutMessage;
            }
            else
            {
                MessageBox.Show("暂没商品价格");
            }

        }
    }
}
