var expect = require('chai').expect;
var itParam = require('mocha-param');
const tacitus = require('../app/tacitus.js');

var romanDictionary =
  [
    { roman: 'I', number: '1' },
    { roman: 'II', number: '2' },
    { roman: 'III', number: '3' }, 
    { roman: 'IV', number: '4' },
    { roman: 'V', number: '5' },
    { roman: 'VI', number: '6' },
    { roman: 'VII', number: '7' },
    { roman: 'VIII', number: '8' },
    { roman: 'IX', number: '9' },
    { roman: 'X', number: '10' },
    { roman: 'XI', number: '11' },
    { roman: 'XII', number: '12' },
    { roman: 'XIII', number: '13' },
    { roman: 'XIV', number: '14' },
    { roman: 'XV', number: '15' },
    { roman: 'XVI', number: '16' },
    { roman: 'XVII', number: '17' },
    { roman: 'XVIII', number: '18' },
    { roman: 'XIX', number: '19' },
    { roman: 'XX', number: '20' },
    { roman: 'XXI', number: '21' },
  ];

describe("Tacitus", function () {
  beforeEach(function () {
    _tacitus = new tacitus();
  });

  describe("RomanToNumber", function () {
    itParam("should convert ${value.roman} -> ${value.number}", romanDictionary, function (dictionary) {
      expect(_tacitus.convert(dictionary.roman)).to.equal(dictionary.number);
    });
  });

  describe("NumberToRoman", function () {
    itParam("should convert ${value.number} -> ${value.roman}", romanDictionary, function (dictionary) {
      expect(_tacitus.convert(dictionary.number)).to.equal(dictionary.roman);
    });
  });
});