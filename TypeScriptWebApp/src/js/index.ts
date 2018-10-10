const CONVERSIONCONST:number = 28.34952;
let convertToGramsButton: HTMLButtonElement = <HTMLButtonElement> document.getElementById("convertToGramsButton");
let convertToOuncesButton: HTMLButtonElement = <HTMLButtonElement> document.getElementById("convertToOuncesButton");
let result: HTMLDivElement = <HTMLDivElement> document.getElementById("outputField")
let input: HTMLInputElement = <HTMLInputElement> document.getElementById("inputField")

function GramsToOunces(grams: number): number {
    return grams/CONVERSIONCONST;
}

function OuncesToGrams(ounces: number): number {
    return ounces*CONVERSIONCONST;
}

convertToGramsButton.addEventListener("click", MouseEvent => {
    result.innerHTML = (OuncesToGrams(Number(input.value))) + " grams";
})

convertToOuncesButton.addEventListener("click", MouseEvent => {
    result.innerHTML = (GramsToOunces(Number(input.value))) + " ounces";
})