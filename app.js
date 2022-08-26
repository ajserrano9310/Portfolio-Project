
let sectionBtns = document.querySelectorAll('.section-btn');

for(let i = 0; i < sectionBtns.length; i++)
{
    sectionBtns[i].addEventListener('click', myFunction);
}


function removeClass1()
{
    let element = document.getElementById('about-me'); 
    element.classList.remove('container-grid');
    element.classList.add('active');
}

function removeClass2()
{

    let element = document.getElementById('about-me'); 
    element.classList.remove('active');
    element.classList.add('container-grid');

}

function myFunction(e)
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


}