using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsForms
{
    internal class TextInputs
    {
        static Dictionary<TextBoxBase, string> _movieTextInputs;
        public static MyForm Form;

        public static void SetDefaultTexts(Dictionary<TextBoxBase, string> movieTextInputs)
        {
            _movieTextInputs = movieTextInputs;
        }

        public static void ResetAllTextElementsToDefaultTexts()
        {
            TextBoxBase[] textElements = _movieTextInputs.Keys.ToArray();
            foreach (TextBoxBase element in textElements)
            {
                ResetToDefaultText(element);
            }
        }

        public static bool MovieParamsAreValid()
        {
            if(Form.txtElokuvanNimi.Text == "")
            {
                MessageBox.Show("nimi-kenttä on tyhjä");
                return false;
            }
            if(Form.txtElokuvanJulkaisuvuosi.Text == "") 
            {
                MessageBox.Show("julkaisuvuosi-kenttä on tyhjä");          
                return false;
            }
            else
            {
                if(!IsNumber(Form.txtElokuvanJulkaisuvuosi.Text)) {
                    MessageBox.Show("julkaisuvuosi ei ole numeroita");
                    return false;
                }
            }
            if (Form.txtElokuvanKesto.Text == "")
            {
                MessageBox.Show("kesto-kenttä on tyhjä");
                return false;
            }
            else
            {
                if (!IsNumber(Form.txtElokuvanKesto.Text))
                {
                    MessageBox.Show("kesto ei ole numeroita");
                    return false;
                }
            }
            return true;


            //input
            //numbers
            //log error message
        }

        private static bool IsNumber(string str)
        {
            return int.TryParse(str, out _);
        }
        

        public static void ResetToDefaultText(TextBoxBase element)
        {
            if (_movieTextInputs.ContainsKey(element))
            {
                element.Text = _movieTextInputs[element];
            }
            else
            {
                MessageBox.Show($"no default value for field {element.Name}");
            }
        }
        public static void ResetToDefaultTextIfEmpty(TextBoxBase element)
        {
            if (_movieTextInputs.ContainsKey(element))
            {
                if (element.Text == "")
                {
                    element.Text = _movieTextInputs[element];
                }
            }
            else
            {
                MessageBox.Show($"no default value for field {element.Name}");
            }
        }
    }
}
