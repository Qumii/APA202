let card = document.createElement("div");

card.style.width = "350px";
card.style.border = "1px solid #f6f6f6";
card.style.borderRadius = "10px";
card.style.margin = "20px auto";
card.style.fontFamily = "Google Sans, sans-serif";
card.style.letterSpacing = "0.5px";
card.style.backgroundColor = "#f9f9f9";



let imgDiv = document.createElement("div");
imgDiv.style.position = "relative";
imgDiv.style.backgroundColor = "#fff";



let image = document.createElement("img");
image.src = "./assets/image/house.jpg";
image.style.width = "100%";
image.style.borderRadius = "10px";
image.style.display = "block";



let heartBtn = document.createElement("button");
heartBtn.innerHTML = '<i class="fa-regular fa-heart"></i>';
heartBtn.style.position = "absolute";
heartBtn.style.top = "10px";
heartBtn.style.right = "10px";
heartBtn.style.color = "white";
heartBtn.style.fontSize = "24px";
heartBtn.style.cursor = "pointer";
heartBtn.style.border = "none";
heartBtn.style.background = "transparent";


heartBtn.onclick = function () {
  if (heartBtn.style.color === "white") {
    heartBtn.style.color = "red";
  } else {
    heartBtn.style.color = "white";
  }
};



imgDiv.appendChild(image);
imgDiv.appendChild(heartBtn);




let content = document.createElement("div");
content.style.padding = "15px";
content.style.backgroundColor = "#fff";



let category = document.createElement("p");
category.innerText = "DETACHED HOUSE - 5Y OLD";
category.style.fontSize = "12px";
category.style.fontWeight = "bold";
category.style.color = "#626262";
category.style.fontWeight = "700";




let price = document.createElement("h2");
price.innerText = "$750,000";
price.style.margin = "5px 0";
price.style.fontWeight = "400";




let address = document.createElement("p");
address.innerText = "742 Evergreen Terrace";
address.style.color = "#626262";


content.appendChild(category);
content.appendChild(price);
content.appendChild(address);



let rooms = document.createElement("div");
rooms.style.display = "flex";
rooms.style.borderTop = "1px solid #ededed";
rooms.style.padding = "10px 5px";
rooms.innerHTML =
  '<span style="color:#8a8a8a"><i class="fa-solid fa-bed"></i>  <span style="color:black; font-weight: 600">3</span> Bedrooms</span> <span style="margin-left:20px; color:#8a8a8a"><i class="fa-solid fa-bath"></i> <span style="color:black; font-weight: 600">2</span> Bathrooms</span>';
rooms.style.fontSize = "14px";
rooms.style.backgroundColor = "#fff";



let realtorText = document.createElement("div");
realtorText.style.width = "100%";
realtorText.style.height = "35px";
realtorText.style.fontSize = "12px";
realtorText.style.color = "#8a8a8a";
realtorText.style.backgroundColor = "#f9f9f9";
realtorText.style.borderTop = "1px solid #ededed";



let realtorTitle = document.createElement("h3");
realtorTitle.innerText = "REALTOR";
realtorTitle.style.paddingLeft = "20px";
realtorTitle.style.paddingTop = "12px";


realtorText.appendChild(realtorTitle);




let realtor = document.createElement("div");
realtor.style.padding = "20px";
realtor.style.backgroundColor = "#f9f9f9";
realtor.style.display = "flex";
realtor.style.alignItems = "center";
realtor.style.borderRadius = "10px";



let realtorImg = document.createElement("img");
realtorImg.src = "./assets/image/pp.jpg";
realtorImg.style.width = "40px";
realtorImg.style.height = "40px";
realtorImg.style.borderRadius = "50%";
realtorImg.style.marginRight = "10px";



let realtorInfo = document.createElement("div");
realtorInfo.innerHTML =
  '<strong>Tiffany Heffner</strong> <br> <span style="fons-size:12px; color:#777">(555) 555-4321</span>';
realtor.appendChild(realtorImg);
realtor.appendChild(realtorInfo);



card.appendChild(imgDiv);
card.appendChild(content);
card.appendChild(rooms);
card.appendChild(realtorText);
card.appendChild(realtor);




document.body.appendChild(card);
