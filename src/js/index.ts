let Oz2Gram = 28.34952;
let Gram2Oz = 0.03527396195;
let Output:HTMLDivElement = <HTMLDivElement> document.getElementById("output");

document.getElementById("Gram2Ounces").addEventListener("click", () => grams2Ounces());
document.getElementById("Ounces2Gram").addEventListener("click", () => ounces2Gram());

function ConvertGramToOunces():number{
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("numberTextinput")).value);
    return inputWeight * Gram2Oz;
}

function ConvertOuncesToGram():number{
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("numberTextinput")).value);
    return inputWeight * Oz2Gram;
}

function grams2Ounces(){
    let result:number = ConvertGramToOunces();
    if (result > 0){
       Output.innerHTML = result.toString() + " Ounces";
    }
}

function ounces2Gram(){
    let result:number = ConvertOuncesToGram();
    if (result > 0){
        Output.innerHTML = result.toString() + " Grams"
    }
}