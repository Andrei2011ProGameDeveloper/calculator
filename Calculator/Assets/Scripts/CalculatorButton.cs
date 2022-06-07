using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class CalculatorButton : MonoBehaviour
    {
        [SerializeField] private TMP_Text _numberButton;
        private DataTable dataTable = new DataTable();

        public TMP_InputField _mainText;

        public void OnClickButton()
        {
            buttonCheck(_numberButton.text[0]);
        }

        public void OnClickButtonClear()
        {
            _mainText.text = "";
        }
        public void OnClickButtonE()
        {
            _mainText.text = "2.7";
        }


        public void buttonCheck(char buttonNumber)
        {
            if ((buttonNumber >= '0') || buttonNumber == '.' || buttonNumber == '+' || buttonNumber == '-' || buttonNumber == '*' || buttonNumber == '/' || buttonNumber == '%' || buttonNumber == '(' || buttonNumber == ')')
            {
                if (_mainText.text.Length < 12 )
                {
                    if (_mainText.text == "0" && buttonNumber != '.')
                    {
                        _mainText.text = "";
                    }
                    _mainText.text += buttonNumber;
                }
            }
        }

        public void OnClickButtonResult()
        {
            _mainText.text = (dataTable.Compute(_mainText.text, "").ToString());
        }
    }

}