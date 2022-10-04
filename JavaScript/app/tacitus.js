function tacitus(){
    
    const _numberToRomanDictionary =
        [
            { Roman: 'X', Number: 10 },
            { Roman: 'IX', Number: 9 },
            { Roman: 'V', Number: 5 },
            { Roman: 'IV', Number: 4 },
            { Roman: 'I', Number: 1 }
        ]; 

    function convert(input){
        var convertedValue;
        if (isARomanNumeral(input))
            convertedValue = convertRomanToNumber(input);
        else
            convertedValue = convertNumberToRoman(input);

        return convertedValue;
    }

    function isARomanNumeral(input){
        return isNaN(Number(input));
    }

    function convertRomanToNumber(input){
        let romanNumeral = input;
        let runningTotal = 0;

        HandleIX();
        HandleXs();
        HandleIV();
        HandleV();
        HandleIs();

        return runningTotal.toString();

        function HandleIX(){
            if (romanNumeral.includes("IX")){
                romanNumeral = replaceAll(romanNumeral, "IX", "");
                runningTotal += 9;
            }
        }

        function HandleXs(){
            while (romanNumeral.includes("X")){
                romanNumeral = romanNumeral.replace('X','');
                runningTotal += 10;
            }
        }

        function replaceAll(target, search, replacement) {
            return target.replace(new RegExp(search, 'g'), replacement);
        };

        function HandleIV(){
            if (romanNumeral.includes("IV")){
                romanNumeral = replaceAll(romanNumeral, "IV", "");
                runningTotal += 4;
            }
        }

        function HandleV(){
            if (romanNumeral.includes("V")){
                romanNumeral = replaceAll(romanNumeral, "V", "");
                runningTotal += 5;
            }
        }

        function HandleIs(){
            while (romanNumeral.includes("I")){
                romanNumeral = romanNumeral.replace('I','');
                runningTotal++;
            }
        }
    }

    function convertNumberToRoman(input){
        var number = Number(input);
        var romanNumeral = "";
        while (number != 0) {
            for (var i = 0; i < _numberToRomanDictionary.length; i++) {
                var entry = _numberToRomanDictionary[i];
                while (number >= entry.Number) {
                    romanNumeral += entry.Roman;
                    number -= entry.Number;
                }
            }
        }
        return romanNumeral;        
    }

    return {
        convert: convert
    }
};

module.exports = tacitus;