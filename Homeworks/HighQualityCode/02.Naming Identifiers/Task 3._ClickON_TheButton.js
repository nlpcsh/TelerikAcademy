function clickOnTheButton(event, argument) {
    var currentWindow = window,
        currentBrowser = currentWindow.navigator.appCodeName;
    if (currentBrowser === "Mozilla") {
        alert("Yes");
    } else {
        alert("No");
    }
}
