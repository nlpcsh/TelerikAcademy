var elementId = "root",
    contents = ['Content #1', 'Content #2'];
//addElements(elementId, contents);

var count = 15,
        contents = Array.apply(null, { length: count })
          .map(function (_, index) {
          return 'Content #' + index;
        }),
        selector = 'root';

addElements(selector, contents);

function addElements(element, contents) {
    element = element || "";
    contents = contents || [];

    if (element === "") {
        throw new Error("No element is provided!");
    }
    if (typeof(element) !== "string") {
        throw new Error("No valid ID is provided!");
    }
    if (contents.length === 0) {
        throw new Error("No valid content is provided!");
    }

    var domElement = document.getElementById(element);

    if (!domElement) {
        throw new Error("No valid DOM Element is selected!");
    }

    domElement.innerHtml = "";
    var div, selectedDiv;

    for (var i = 0, len = contents.length; i < len; i += 1) {
        div = document.createElement("div");
        div.className = "divId" + i;
        div.style.border = '1px solid black';
        div.style.width = '100px';
        div.style.height = '50px';
        //div.innerText = contents[i];
        div.innerHtml = contents[i];
        domElement.appendChild(div);
    }

    // var selectedDivs = document.getElementsByClassName("some-class");

    // for (i = 0, len = selectedDivs.length; i < len; i += 1) {
    //     selectedDivs[i].style.width = '100px';
    //     selectedDivs[i].style.height = '50px';
    //     selectedDivs[i].style.border = '1px solid black';
    //     //selectedDivs[i].innerHtml = contents[i];
    //     selectedDivs[i].innerText = contents[i];
    // }

    var $divs = $('#' + selector + ' *');
    console.log($divs.length);

    $divs.each(function (index, div) {
        console.log(div.innerHtml);
        //expect(contents).to.contain(div.innerHTML);
    });
}
