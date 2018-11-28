$(document).ready(function() {
  $("form#cal").submit(function(event) {
    event.preventDefault();

    // var vowels = ["a", "e", "i", "o", "u"];

    var sentence = $("input#puzzle").val();


      for (var index = 0; index < sentence.length; index +=1) {
        var vowels = ["a", "e", "i", "o", "u"];
        var dash = sentence.replace(/[aeiou]/g, "-");

      }
      alert(dash);

    event.preventDefault();

  });
});
