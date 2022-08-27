
let sectionBtns = document.querySelectorAll('.section-btn');

const titleColors = {
    "projects": {deepBlue: "#041562"},
    "about-me": {deepRed: "#EC255A"},
    "contact-me": {deepTeal: "#24A19C"}, 
    "resume":{ deepCeleste: "#66BFBF"} 

}

for(let i = 0; i < sectionBtns.length; i++)
{
    sectionBtns[i].addEventListener('click', activateSection);
}

function activateSection(e)
{
    let sections = document.querySelectorAll('.section');
    let sectionID = e.target.id;
    console.log(sectionID);

    if(sectionID)
    {
        sections.forEach((section)=>{
            section.classList.remove("active");
        })
    }

    let elementToDisplay = sectionID + "-wrapper"; 
    console.log(elementToDisplay);
    let sectionToActivate = document.getElementById(elementToDisplay);
    console.log(sectionToActivate);
    sectionToActivate.classList.add('active');
    changeSectionTitle(sectionID);
}

function changeSectionTitle(sectionID)
{
    let titleColor = titleColors[sectionID];
    console.log(titleColor);
    let title = document.getElementById("section-title");
    console.log(title);
    title.innerHTML = sectionID; 
}