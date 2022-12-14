using NUnit.Framework;

namespace RomanNumeralKataReadyForRefactoring
{
	[TestFixture]
	[Category("KataUnitTests")]
	public class NumberToRomanTests
	{
		[TestCase("I", "1")]
		[TestCase("II", "2")]
		[TestCase("III", "3")]
		[TestCase("IV", "4")]
		[TestCase("V", "5")] 
		[TestCase("VI", "6")]
		[TestCase("VII", "7")]
		[TestCase("VIII", "8")]
		[TestCase("IX", "9")]
		[TestCase("X", "10")]
		[TestCase("XI", "11")]
		[TestCase("XII", "12")]   
		[TestCase("XIII", "13")]
		[TestCase("XIV", "14")]
		[TestCase("XV", "15")]
		[TestCase("XVI", "16")]
		[TestCase("XVII", "17")]
		[TestCase("XVIII", "18")]
		[TestCase("XIX", "19")]
		[TestCase("XX", "20")]
		[TestCase("XXI", "21")]
		[TestCase("XXII", "22")]
		[TestCase("XXIII", "23")]
		[TestCase("XXIV", "24")]
		[TestCase("XXV", "25")]
		[TestCase("XXVI", "26")]
		[TestCase("XXVII", "27")]
		[TestCase("XXVIII", "28")]
		[TestCase("XXIX", "29")]
		[TestCase("XXX", "30")]
		[TestCase("XXXI", "31")]
		[TestCase("XXXII", "32")]
		[TestCase("XXXIII", "33")]
		[TestCase("XXXIV", "34")]
		[TestCase("XXXV", "35")]
		[TestCase("XXXVI", "36")]
		[TestCase("XXXVII", "37")]
		[TestCase("XXXVIII", "38")]
		[TestCase("XXXIX", "39")]
		[TestCase("XL", "40")]
		[TestCase("XLI", "41")]
		[TestCase("XLII", "42")]
		[TestCase("XLIII", "43")]
		[TestCase("XLIV", "44")]
		[TestCase("XLV", "45")]
		[TestCase("XLVI", "46")]
		[TestCase("XLVII", "47")]
		[TestCase("XLVIII", "48")]
		[TestCase("XLIX", "49")]
		[TestCase("L", "50")]
		[TestCase("LI", "51")]
		[TestCase("LII", "52")]
		[TestCase("LIII", "53")]
		[TestCase("LIV", "54")]
		[TestCase("LV", "55")]
		[TestCase("LVI", "56")]
		[TestCase("LVII", "57")]
		[TestCase("LVIII", "58")]
		[TestCase("LIX", "59")]
		[TestCase("LX", "60")]
		[TestCase("LXI", "61")]
		[TestCase("LXII", "62")]
		[TestCase("LXIII", "63")]
		[TestCase("LXIV", "64")]
		[TestCase("LXV", "65")]
		[TestCase("LXVI", "66")]
		[TestCase("LXVII", "67")]
		[TestCase("LXVIII", "68")]
		[TestCase("LXIX", "69")]
		[TestCase("LXX", "70")]
		[TestCase("LXXI", "71")]
		[TestCase("LXXII", "72")]
		[TestCase("LXXIII", "73")]
		[TestCase("LXXIV", "74")]
		[TestCase("LXXV", "75")]
		[TestCase("LXXVI", "76")]
		[TestCase("LXXVII", "77")]
		[TestCase("LXXVIII", "78")]
		[TestCase("LXXIX", "79")]
		[TestCase("LXXX", "80")]
		[TestCase("LXXXI", "81")]
		[TestCase("LXXXII", "82")]
		[TestCase("LXXXIII", "83")]
		[TestCase("LXXXIV", "84")]
		[TestCase("LXXXV", "85")]
		[TestCase("LXXXVI", "86")]
		[TestCase("LXXXVII", "87")]
		[TestCase("LXXXVIII", "88")]
		[TestCase("LXXXIX", "89")]
		[TestCase("XC", "90")]
		[TestCase("XCI", "91")]
		[TestCase("XCII", "92")]
		[TestCase("XCIII", "93")]
		[TestCase("XCIV", "94")]
		[TestCase("XCV", "95")]
		[TestCase("XCVI", "96")]
		[TestCase("XCVII", "97")]
		[TestCase("XCVIII", "98")]
		[TestCase("XCIX", "99")]
		[TestCase("C", "100")] 
 		public void ShouldConvertRomanNumeralsToIntegers(string expectedRomanNumeralOutput, string integerInput)
		{
			//arrange
			var romanNunmeralConverter = new RomanNumeralConverter.RomanNumeralConverter();

			//act
			var result = romanNunmeralConverter.Convert(integerInput);

			//assert
			Assert.That(result, Is.EqualTo(expectedRomanNumeralOutput));
		}
	}
}
