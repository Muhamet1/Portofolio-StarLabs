const navMenu = document.getElementById("nav-menu"),
  toggleMenu = document.getElementById("nav-toggle"),
  closeMenu = document.getElementById("nav-close");

toggleMenu.addEventListener("click", () => {
  navMenu.classList.toggle("show");
});

closeMenu.addEventListener("click", () => {
  navMenu.classList.remove("show");
});

const navLink = document.querySelectorAll(".nav__link");

function linkAction() {
  navMenu.classList.remove("show");
}
navLink.forEach((n) => n.addEventListener("click", linkAction));

const sections = document.querySelectorAll("section[id]");

window.addEventListener("scroll", scrollActive);

function scrollActive() {
  const scrollY = window.pageYOffset;

  sections.forEach((current) => {
    const sectionHeight = current.offsetHeight;
    const sectionTop = current.offsetTop - 50;
    sectionId = current.getAttribute("id");

    if (scrollY > sectionTop && scrollY <= sectionTop + sectionHeight) {
      document
        .querySelector(".nav__menu a[href*=" + sectionId + "]")
        .classList.add("active");
    } else {
      document
        .querySelector(".nav__menu a[href*=" + sectionId + "]")
        .classList.remove("active");
    }
  });
}

/*Fetch API Projects */
fetch("https://localhost:7114/api/Projects")
  .then((data) => {
    return data.json();
  })
  .then((completedata) => {
    let data1 = "";

    completedata.map((values) => {
      data1 += `<div class="works__img">
        <img src="${values.photoUrl}" alt="">
        <div class="works__data">
            <a href="${values.projectLink}" class="works__link"><i class="bx bx-link-alt"></i></a>
            <span class="works__subtitle">${values.projectSubTitle}</span>
            <span class="works__title">${values.projectTitle}</span>
            <p class="works__description">${values.projectDescription}</p>
        </div>
    </div>`;
    });
    document.getElementById("api").innerHTML = data1;
  })
  .catch((err) => {
    console.log(err);
  });

/*Post Request using fetch. Contact Form*/

var form = document.getElementById("form");

form.addEventListener("submit", function (e) {
  var name = document.getElementById("name").value;
  var email = document.getElementById("email").value;
  var message = document.getElementById("message").value;

  fetch("https://localhost:7114/api/Contacts", {
    method: "POST",
    body: JSON.stringify({
      contactName: name,
      contactEmail: email,
      contactMessage: message,
    }),
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
  })
    .then(function (response) {
      return response.json();
    })
    .then(function (data) {
      console.log(data);
    })
    .then(alert("Message sent succesfully"));
});

/*SCROLL DELAY ********/

function reveal() {
  var reveals = document.querySelectorAll(".reveal");

  for (var i = 0; i < reveals.length; i++) {
    var windowHeight = window.innerHeight;
    var elementTop = reveals[i].getBoundingClientRect().top;
    var elementVisible = 150;

    if (elementTop < windowHeight - elementVisible) {
      reveals[i].classList.add("active");
    } else {
      reveals[i].classList.remove("active");
    }
  }
}

window.addEventListener("scroll", reveal);
