
let sectionBtns = document.querySelectorAll('.section-btn');

const titleColors = {
    "projects": {color: "#041562"},
    "about-me": {color: "#EC255A"},
    "contact-me": {color: "#24A19C"}, 
    "resume":{ color: "#66BFBF"} 

}

for(let i = 0; i < sectionBtns.length; i++)
{
    sectionBtns[i].addEventListener('click', activateSection);
}

function activateSection(e)
{
    let sections = document.querySelectorAll('.section');
    let sectionID = e.target.id;

    if(sectionID)
    {
        sections.forEach((section)=>{
            section.classList.remove("active");
        })
    }

    let elementToDisplay = sectionID + "-wrapper"; 
    let sectionToActivate = document.getElementById(elementToDisplay);
    sectionToActivate.classList.add('active');
    changeSectionTitle(sectionID);
}

function changeSectionTitle(sectionID)
{
    // Change the colors of the square
    let titleColor = titleColors[sectionID];
    let square = document.getElementById('square');
    square.style.backgroundColor = titleColor.color;

    // Change the title text
    let title = document.getElementById("section-title");
    title.innerHTML = sectionID; 
}