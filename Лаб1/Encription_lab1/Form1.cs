using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encription_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string strKey = "";
            string strInitial = "";
            string resultEncrypt = "";
            string resultDecrypt = "";
            cipherCezar cc;
            cipherVigener cv;
            Digramm d;

            #region Цезарь

            cc = new cipherCezar();

                if (rbCezar.Checked)
                {
                    if (rbEncrypt.Checked)
                    {
                        if (tbInitialText.Text != string.Empty)
                        {
                            strInitial = tbInitialText.Text;
                            resultEncrypt = cc.Encryption(strInitial.ToLower());
                            tbDecriptionText.Text = resultEncrypt;
                        }
                    }
                    else if (rbDecrypt.Checked)
                    {
                        if (tbInitialText.Text != string.Empty)
                        {
                            strInitial = tbInitialText.Text;
                            resultDecrypt = cc.Decryption(strInitial.ToLower());
                            tbDecriptionText.Text = resultDecrypt;
                        }
                    }
                }          
            #endregion

            #region Виженер

            cv = new cipherVigener();

            if (rbVigener.Checked)
            {
                if (rbEncrypt.Checked)
                {
                    if (tbInitialText.Text != string.Empty)
                    {
                        strInitial = tbInitialText.Text;

                        if (tbKey.Text != string.Empty)
                        {
                            strKey = tbKey.Text;

                            resultEncrypt = cv.Encode(strInitial, strKey);
                            tbDecriptionText.Text = resultEncrypt;
                        }
                    }
                } else if (rbDecrypt.Checked)
                {
                    if (tbInitialText.Text != string.Empty)
                    {
                        strInitial = tbInitialText.Text;

                        if (tbKey.Text != string.Empty)
                        {
                            strKey = tbKey.Text;

                            resultDecrypt = cv.Decode(strInitial, strKey);
                            tbDecriptionText.Text = resultDecrypt;
                        }
                    }
                }
            }
            #endregion

            #region Биграммы

            d = new Digramm();

            if (rbDigramm.Checked)
            {
                if (rbEncrypt.Checked)
                {
                    if (tbInitialText.Text != string.Empty)
                    {
                        strInitial = tbInitialText.Text;

                        if (tbKey.Text != string.Empty)
                        {
                            strKey = tbKey.Text;
                            resultEncrypt = d.Encrypt(strInitial, strKey);
                            tbDecriptionText.Text = resultEncrypt;
                        }
                    }
                }
                //else if (rbDecrypt.Checked)
                //{
                //    if (tbInitialText.Text != string.Empty)
                //    {
                //        strInitial = tbInitialText.Text;

                //        if (tbKey.Text != string.Empty)
                //        {
                //            strKey = tbKey.Text;
                //            resultDecrypt = d.(strKey, strInitial);
                //            tbDecriptionText.Text = resultDecrypt;
                //        }
                //    }
                //}
            }
            #endregion
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInitialText.Clear();
            tbDecriptionText.Clear();
        }
    }
}
