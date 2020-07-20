const eventHub = document.querySelector(".container")
const selectedColorDiv = document.getElementById("selectedColor")

eventHub.addEventListener("click", event => {
    switch (event.target.id) {
        case "blue":
            selectedColorDiv.innerHTML = ""
            selectedColorDiv.style.backgroundColor = "rgb(0, 120, 215)"
            break;
        case "orange":
            selectedColorDiv.style.backgroundColor = "rgb(216, 59, 1)"
            selectedColorDiv.innerHTML = ""
            break;
        case "red":
            selectedColorDiv.innerHTML = ""
            selectedColorDiv.style.backgroundColor = "rgb(232, 17, 35)"
            break;
        case "purple":
            selectedColorDiv.innerHTML = ""
            selectedColorDiv.style.backgroundColor = "rgb(92, 45, 145)"
            break;
        case "green":
            selectedColorDiv.innerHTML = ""
            selectedColorDiv.style.backgroundColor = "rgb(16, 134, 16)";
            break;
        default:
            selectedColorDiv.innerHTML = "None"
            selectedColorDiv.style.backgroundColor = "";
            break;
    }
})