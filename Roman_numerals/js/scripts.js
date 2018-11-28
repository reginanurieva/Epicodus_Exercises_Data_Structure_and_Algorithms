function convertToRoman(string){
  var initialInput=parseInt(string);
  if (isNotNum(string)) {
    alert("Please enter a valid number");
  } else if (numGreater(string)) {
    alert("Please enter a number lower than 4,000.");
  } else {
    var romans = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
    var values=[1000,900,500,400,100,90,50,40,10,9,5,4,1];
    var outputValue = '';
      for(i=0; i < romans.length; i++){
        while(initialInput % values[i] < initialInput){
          outputValue = outputValue + romans[i];
          initialInput = initialInput - values[i];
        }
      }
    return outputValue;
  }
};

//   var result = '';
//   for(var key in romans){
//     if (num >= romans[key]){
//       result += romans[key]* Math.trunc(num / romans[key]);
//       num -= romans[key] * Math.trunc(num/romans);
//     }
//   }
// }
// console.log(convertToRoman(36));







//Check if string has a number
function isNotNum(string) {
  var regex = /[^0-9]/;
  return regex.test(string);
}

//Check if numbers are less than 3999
function numGreater(string){
  if (string > 3999){
    return true;
  } else {
    return false;
  }
}
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
$(document).ready(function() {

  $("#formOne").submit(function(event) {
    event.preventDefault();
    var userInput = $("#inputBox").val();
    var userOutput = convertToRoman(userInput);
    $(".result").text(userOutput);
    // alert(hasNum(userInput));
    // alert(numGreater(userInput));
    //alert(convertToRoman(result));
    //var outputResult = eachNum(inputArray);

    //$(".output").text(outputResult);

  });
});
