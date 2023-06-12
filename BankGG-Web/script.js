let r=Math.floor(Math.random()*10);
let elem=document.getElementsByTagName('h2');
//console.log(elem);
elem[0].innerText="enter the no \""+r+"\" in the textbox to verify you are not a bot";

let elembutton=document.getElementById("myInput");
console.log(elembutton);
elembutton.addEventListener("input",function()
{
    if(elembutton.value==r.toString())
    {
        elembutton.classList.add("ggs1")
        document.getElementsByTagName('h2')[0].classList.add("ggs1");
        document.getElementsByTagName('button')[0].classList.remove("ggs1");
        document.getElementsByTagName('button')[0].classList.add("button-10");
    }
    else
    {
        console.log("no");
    }
})