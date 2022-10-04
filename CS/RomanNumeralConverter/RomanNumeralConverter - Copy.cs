using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralConverter
{
	public class RomanNumeralConverter
	{
		private string _romanNumeralToConvert;
		private int _romanNumeralConvertedToInt;

		private int _intToConvert;
		private string _intConvertedToRomanNumeral;
		private readonly Dictionary<string, string> _romanToNumberDictionary = new Dictionary<string, string>()
		{
			{"V", "IIIII"},     
			{"IV", "IIII"},
			{"X", "VV"}, 
			{"IX", "VIV"},
			{"L", "XXXXX"},
			{"XL", "XXXX"},
			{"C", "LL"},
			{"XC", "LXL"},
		};

		public string Convert(string input)
		{
			if (IsAnInteger(input))
				return ConvertIntegerToRomanNumeral(input); 
			else
				return ConvertRomanNumeralToInteger(input); 
		}

		private bool IsAnInteger(string input)
		{
			return int.TryParse(input, out int convertedInt);
		}

		private string ConvertIntegerToRomanNumeral(string input)
		{
			Init(input); 
			ExplodeIntegerToAllIs();
			ReplaceIsWithRomanDictionaryEntries();

			return _intConvertedToRomanNumeral;
		}

		private void Init(string input)
		{
			int.TryParse(input, out _intToConvert);
			_intConvertedToRomanNumeral = "";
		}

		private void ExplodeIntegerToAllIs()
		{
			for (int i = 0; i < _intToConvert; i++)
				_intConvertedToRomanNumeral += "I";
		}

		private void ReplaceIsWithRomanDictionaryEntries()
		{
			foreach (var entry in _romanToNumberDictionary)
				_intConvertedToRomanNumeral = _intConvertedToRomanNumeral.Replace(entry.Value, entry.Key);
		}

		private string ConvertRomanNumeralToInteger(string input)
		{
			Initialize(input);
			HandleXC();
			HandleC();
			HandleXL();
			HandleL();
			HandleIX();
			HandleX();
			HandleIV();
			HandleV();
			HandleIs();

			var result = _romanNumeralConvertedToInt.ToString();
			return result;
		}

		private void Initialize(string input)
		{
			_romanNumeralToConvert = input;
			_romanNumeralConvertedToInt = 0;
		}

		private void HandleXC()
		{
			if (_romanNumeralToConvert.Contains("XC"))
			{
				_romanNumeralToConvert = _romanNumeralToConvert.Replace("XC", "");
				_romanNumeralConvertedToInt += 90;
			}
		}

		private void HandleC()
		{
			var numberOfCs = _romanNumeralToConvert.Count(x => x == 'C');
			_romanNumeralToConvert = _romanNumeralToConvert.Replace("C", "");
			_romanNumeralConvertedToInt += numberOfCs * 100;
		}

		private void HandleXL()
		{
			if (_romanNumeralToConvert.Contains("XL"))
			{
				_romanNumeralToConvert = _romanNumeralToConvert.Replace("XL", "");
				_romanNumeralConvertedToInt += 40;
			}
		}

		private void HandleL()
		{
			if (_romanNumeralToConvert.Contains("L"))
			{
				_romanNumeralToConvert = _romanNumeralToConvert.Replace("L", "");
				_romanNumeralConvertedToInt += 50;
			}
		}

		private void HandleIX()
		{
			if (_romanNumeralToConvert.Contains("IX"))
			{
				_romanNumeralToConvert = _romanNumeralToConvert.Replace("IX", "");
				_romanNumeralConvertedToInt += 9;
			}
		}

		private void HandleX()
		{
			var numberOfXs = _romanNumeralToConvert.Count(x => x == 'X');
			_romanNumeralToConvert = _romanNumeralToConvert.Replace("X", "");
			_romanNumeralConvertedToInt += numberOfXs * 10;
		}

		private void HandleIV()
		{
			if (_romanNumeralToConvert.Contains("IV"))
			{
				_romanNumeralToConvert = _romanNumeralToConvert.Replace("IV", "");
				_romanNumeralConvertedToInt += 4;
			}
		}

		private void HandleV()
		{
			if (_romanNumeralToConvert.Contains("V"))
			{
				_romanNumeralToConvert = _romanNumeralToConvert.Replace("V", "");
				_romanNumeralConvertedToInt += 5;
			}
		}

		private void HandleIs()
		{
			while (_romanNumeralToConvert.Contains("I"))
			{
				_romanNumeralToConvert = RemoveOneCharacter(_romanNumeralToConvert);
				_romanNumeralConvertedToInt++;
			}
		}

		private string RemoveOneCharacter(string input)
		{
			input = input.Substring(1);
			return input;
		}
	}
}
