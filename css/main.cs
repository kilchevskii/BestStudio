@charset "UTF-8";
@font-face {
  font-family: "OpenSans Bold";
  src: url("../fonts/OpenSans/OpenSans-Bold.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-Bold.woff") format("woff");
}
@font-face {
  font-family: "OpenSans Bolditalic";
  src: url("../fonts/OpenSans/OpenSans-BoldItalic.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-BoldItalic.woff") format("woff");
}
@font-face {
  font-family: "OpenSans ExtraBold";
  src: url("../fonts/OpenSans/OpenSans-ExtraBold.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-ExtraBold.woff") format("woff");
}
@font-face {
  font-family: "OpenSans ExtraBolditalic";
  src: url("../fonts/OpenSans/OpenSans-ExtraBoldItalic.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-ExtraBoldItalic.woff") format("woff");
}
@font-face {
  font-family: "OpenSans italic";
  src: url("../fonts/OpenSans/OpenSans-Italic.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-Italic.woff") format("woff");
}
@font-face {
  font-family: "OpenSans light";
  src: url("../fonts/OpenSans/OpenSans-Light.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-Light.woff") format("woff");
}
@font-face {
  font-family: "OpenSans lightitalic";
  src: url("../fonts/OpenSans/OpenSans-LightItalic.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-LightItalic.woff") format("woff");
}
@font-face {
  font-family: "OpenSans Regular";
  src: url("../fonts/OpenSans/OpenSans-Regular.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-Regular.woff") format("woff");
}
@font-face {
  font-family: "OpenSans SemiBold";
  src: url("../fonts/OpenSans/OpenSans-SemiBold.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-SemiBold.woff") format("woff");
}
@font-face {
  font-family: "OpenSans SemiBolditalic";
  src: url("../fonts/OpenSans/OpenSans-SemiBoldItalic.woff2") format("woff2"), url("../fonts/OpenSans/OpenSans-SemiBoldItalic.woff") format("woff");
}
@font-face {
  font-family: "Pacifico Regular";
  src: url("../fonts/Pacifico/Pacifico-Regular.woff2") format("woff2"), url("../fonts/Pacifico/Pacifico-Regular.woff") format("woff");
}
body {
  margin: 0;
}

.wr-container-header {
  display: flex;
  justify-content: space-between;
  max-width: 1170px;
  margin: 0 auto;
  height: 85px;
  padding-top: 4vh;
}

a {
  text-decoration: none;
}

button {
  cursor: pointer;
}

.wr-intro {
  background-image: url("../media/home/home.jpg");
  background-size: cover;
  height: 100vh;
  background-position: bottom;
}

.logo {
  color: #fff;
  font-size: 45px;
  font-family: "OpenSans Bold", serif;
  padding-top: 40px;
  padding-bottom: 40px;
  text-transform: uppercase;
  width: 146px;
  height: 67px;
  border: 2px solid #ddd;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  margin-top: -10px;
}

.nav {
  display: flex;
  -ms-flex-wrap: wrap;
  flex-wrap: wrap;
  padding-left: 0;
  margin-bottom: 0;
  padding: 10px;
  margin-top: -20px;
}

.nav ul > li::after {
  content: "\\\\";
  font-size: 18px;
  font-family: "OpenSans Bold", serif;
  padding-left: 30px;
}

.nav ul {
  display: flex;
  justify-content: space-between;
  color: #fff;
  align-items: center;
  padding-top: 48px;
  padding-bottom: 40px;
  list-style-type: none;
  width: 840px;
}

.nav li {
  padding-left: 30px;
  margin-left: 10px;
}

.nav a {
  font-size: 18px;
  font-family: "OpenSans SemiBold", serif;
  color: white;
  padding-bottom: 4px;
  padding-top: 4px;
  text-transform: uppercase;
}

.nav a:hover {
  color: #000000;
}

.wr-intro-container {
  padding-top: 24.3vh;
  display: flex;
  flex-direction: column;
  margin: 0 auto;
  width: 1050px;
}

.wr-intro-container h2 {
  font-size: 45px;
  font-family: "OpenSans light", serif;
  font-weight: lighter;
  color: white;
  text-transform: uppercase;
  text-align: center;
  letter-spacing: -0.9px;
  margin-top: 2.5vh;
}

.wr-intro-container h1 {
  font-size: 70px;
  font-family: "OpenSans Bold", serif;
  color: white;
  text-transform: uppercase;
  width: 1050px;
  letter-spacing: -4.3px;
  margin-top: -4.5vh;
}

.wr-intro-container h3 {
  font-size: 40px;
  font-family: "OpenSans light", serif;
  font-weight: lighter;
  color: white;
  text-transform: uppercase;
  text-align: center;
  letter-spacing: -2.3px;
  margin-top: -6.3vh;
}

.wr-intro-container button {
  height: 45px;
  width: 160px;
  margin: 0 auto;
  margin-top: 8.4vh;
  font-family: "OpenSans Bold", serif;
  font-size: 15px;
  color: #fff;
  background-color: #e74c3c;
  border: none;
  display: flex;
  justify-content: center;
  align-items: center;
}

.wr-intro-container button:hover {
  color: #000;
}

.wr-about {
  padding-top: 5vh;
  width: 1170px;
  height: 700px;
  margin: 0 auto;
  position: relative;
}

.pre-contain {
  display: flex;
  width: 1100px;
  margin: 0 auto;
  padding-top: 6.4vh;
}

.pre-contain h4 {
  margin-left: 1.5vh;
  font-size: 30px;
  font-family: "OpenSans Bold", serif;
  border-right: solid #e74c3c 4px;
  padding: 0px 2vh 0px 0px;
  text-transform: uppercase;
}

.pre-contain p {
  font-size: 16px;
  font-family: "OpenSans Regular", serif;
  padding-top: 2.7vh;
  padding-left: 2vh;
  line-height: 2.5vh;
  text-transform: uppercase;
}

.our-contain {
  display: flex;
  flex-direction: row;
  margin-top: 11.2vh;
}

.our-icon {
  background-image: url("../media/wr-about/light bulb.png");
  background-repeat: no-repeat;
  background-position: center;
  width: 125px;
  height: 120px;
  border: 2px solid #e74c3c;
  border-radius: 50%;
}

.our-text-contain {
  width: 505px;
  padding-left: 30px;
  padding-right: 70px;
}

.our-text-contain h4 {
  margin-top: -0.8vh;
  margin-left: -0.3vh;
  font-size: 20px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
}

.our-text-contain .text-light-red {
  margin-top: -1vh;
  color: #e74c3c;
  font-family: "OpenSans light", serif;
  font-size: 20px;
}

.our-text-contain p {
  font-size: 16px;
  font-family: "OpenSans Regular", serif;
  margin-top: 3.5vh;
  line-height: 2.7vh;
}

.red-fone {
  background-image: url("../media/wr-about/red-fone.png");
  background-size: cover;
  width: 460px;
  height: 253px;
}

.grey-line {
  margin-top: -2.4vh;
  position: absolute;
  top: 100%;
  width: 1170px;
  height: 2px;
  background-color: grey;
}

.wr-our-skills {
  padding-top: 10.5vh;
  display: flex;
  margin: 0 auto;
  width: 1170px;
  height: 780px;
}

.device-content {
  position: relative;
  display: flex;
  padding-top: 13vh;
  padding-left: 15vh;
  height: 485px;
  width: 500px;
}

.device-image-ipad {
  background-image: url("../media/wr-about/iPad.png");
  position: absolute;
  height: 485px;
  width: 375px;
  background-repeat: no-repeat;
}

.device-image-iphone {
  background-image: url("../media/wr-about/iPhone.png");
  height: 340px;
  width: 177px;
  background-repeat: no-repeat;
  position: absolute;
  top: 45%;
  left: 15%;
}

.wr-our-skills .our-contain {
  display: flex;
  padding-left: 46vh;
}

.wr-our-skills .our-text-contain {
  padding-top: 1.2vh;
  width: 400px;
  padding-left: 30px;
  padding-right: 70px;
}

.wr-our-skills .our-text-contain p {
  margin-top: -1vh;
}

.wr-our-skills .our-icon {
  margin-top: 1vh;
  margin-left: 0.3vh;
  background-image: url("../media/wr-about/params.png");
}

.wr-our-skills ul {
  padding-top: 5.5vh;
  list-style-type: none;
  margin-left: -19.5vh;
}

.wr-our-skills li {
  padding-bottom: 4.6vh;
}

.wr-our-skills li p {
  margin-left: -0.3vh;
  font-size: 16px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
}

.wr-our-skills .statistics-number {
  font-size: 16px;
  font-family: "OpenSans Light", serif;
}

.wr-our-skills li img {
  margin-top: -1vh;
  background-repeat: no-repeat;
  background-size: contain;
  width: 555px;
  height: 10px;
  position: absolute;
}

.content-forest {
  padding-top: 10vh;
  background-image: url("../media/3section/jungle.jpg");
  background-size: cover;
  margin-top: -10vh;
  position: relative;
  height: 600px;
}

.content-forest-text {
  position: absolute;
  color: #fff;
  text-align: center;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}

.content-forest-text h2 {
  white-space: pre;
  font-size: 45px;
  font-family: "OpenSans Bold", serif;
}

.content-forest-text h2 span::before {
  content: "“";
  color: #fff;
  font-family: "OpenSans Bold", serif;
}
.content-forest-text h2 span::after {
  content: "“";
  color: #fff;
}

.orange-line {
  background-color: #e74c3c;
  height: 4px;
  width: 50px;
  display: flex;
  margin: 0 auto;
}

.content-forest-text h4 {
  font-size: 24px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
}

.team-contain {
  display: flex;
  justify-content: space-between;
  padding-top: 10vh;
  width: 1170px;
  height: 600px;
  margin: 0 auto;
}

.people-profile {
  border-top: solid transparent 3px;
  text-align: center;
  width: 270px;
  height: 470px;
}

.people-profile:hover {
  background-color: #f0f0f0;
  border-top: solid #f39c12 3px;
}
.people-profile:hover span {
  background-color: #e74c3c;
}

.people-profile img {
  margin-top: 5vh;
  border: solid #c9c9c9 2px;
  border-radius: 50%;
  box-shadow: 0 0 3px rgba(0, 0, 0, 0.8);
  width: 200px;
  height: 200px;
}

.people-profile h4 {
  margin-top: 0.5vh;
  font-size: 20px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
}

.people-profile p {
  margin-top: -3vh;
  font-family: "OpenSans Regular", serif;
  font-size: 15px;
  color: #ccc;
}

.people-profile span {
  background-color: #ccc;
  width: 20px;
  height: 5px;
  display: flex;
  margin: 0 auto;
  margin-top: -0.8vh;
}

.people-profile h6 {
  margin-top: 1vh;
  font-family: "OpenSans Light", serif;
  font-size: 16px;
  color: #919191;
}

.people-profile ul {
  margin-top: -2vh;
  list-style-type: none;
  display: flex;
}

.people-profile li {
  margin: -2px 9px;
}

.people-profile svg {
  color: grey;
  fill-opacity: 1;
  stroke: #333;
  stroke-width: 0px;
  stroke-opacity: 0;
  width: 20px;
  height: 20px;
}

.people-profile svg:hover {
  color: #f39c12;
}

.circle-content {
  display: flex;
  width: 1170px;
  padding-top: 14vh;
  margin: 0 auto;
  flex-direction: row;
  justify-content: space-between;
}

.circle-contain {
  text-align: center;
  margin: 0 auto;
  height: 270px;
  width: 175px;
}

.circle-contain-border {
  width: 125px;
  height: 120px;
  border: 2px solid #e89612;
  border-radius: 50%;
  position: relative;
  margin: 0 auto;
}

.circle-contain:hover .circle-contain-border {
  border: 2px solid #fff;
}
.circle-contain:hover .circle-contain-border svg {
  fill: #e89612;
}

.circle-contain-border svg {
  fill-opacity: 1;
  fill: #fff;
  stroke-width: 0px;
  stroke-opacity: 0;
  position: absolute;
  top: 36%;
  left: 39.5%;
}

.circle-content h2 {
  margin: 0;
  margin-top: 2vh;
  color: #fff;
  font-size: 45px;
  font-family: "OpenSans Bold", serif;
}

.circle-content h4 {
  margin: 0;
  margin-top: -1.3vh;
  color: #fff;
  font-size: 25px;
  font-family: "OpenSans Bold", serif;
}

.service-content {
  width: 1170px;
  margin: 0 auto;
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}

.service-slide {
  padding-top: 10vh;
  height: 300px;
  width: 375px;
  text-align: center;
}

.service-slide h4 {
  font-size: 20px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
}

.service-slide p {
  font-size: 16px;
  font-family: "OpenSans Regular", serif;
}

.service-content .circle-contain-border {
  width: 90px;
  height: 90px;
}

.service-content .circle-contain-border svg {
  fill: #000;
  top: 35%;
  left: 35.5%;
  transform: translate(0%, -5%);
}

.service-slide:hover .circle-contain-border {
  background-color: #e89612;
}
.service-slide:hover .circle-contain-border svg {
  fill: #fff;
}

.wr-service-content .grey-line {
  padding-top: 1vh;
}

.wr-service-content .grey-lines {
  width: 1170px;
  height: 2px;
  background-color: grey;
  position: absolute;
  margin-top: 70vh;
}

.wr-package-service {
  display: flex;
  justify-content: space-around;
  padding-top: 45vh;
  width: 1170px;
  height: 700px;
  margin: 0 auto;
}

.package-pricing {
  height: 305px;
  width: 315px;
}

.package-pricing-border {
  display: flex;
  width: 120px;
  height: 120px;
  border: 2px solid #f39c12;
  border-radius: 50%;
}

.package-pricing-border svg {
  margin: 5vh auto;
}

.package-pricing h4 {
  font-size: 20px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
}

.package-pricing p {
  font-size: 16px;
  font-family: "OpenSans Regular", serif;
}

.pricing-table {
  display: flex;
  width: 750px;
  height: 445px;
}

.pricing-table ul {
  padding: 0;
  margin: 0;
  list-style-type: none;
}

.pricing-table li, ol {
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 0;
  margin: 0;
  border: solid #e6e6e6 0.1px;
  width: 250px;
  height: 50px;
  font-size: 16px;
  font-family: "OpenSans Regular", serif;
  color: #8a8a8a;
}

.pricing-table .table-basic, .table-gold, .table-silver {
  border-top: solid transparent 15px;
}

.pricing-table ol {
  background-color: #fafafa;
}

.pricing-table .stroke-price, .stroke-button {
  width: 250px;
  height: 120px;
}

.stroke-price {
  display: flex;
  flex-direction: column;
}

.stroke-price h4, h3 {
  font-size: 22px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
  color: #000;
}

.stroke-price h3 {
  margin-top: -2vh;
}

.stroke-price h4 {
  margin-top: 2vh;
}

.stroke-price .orange-line {
  position: absolute;
  background-color: #f39c12;
}

.pricing-table button {
  width: 130px;
  height: 40px;
  color: #000;
  background-color: #fff;
  font-size: 14px;
  font-family: "OpenSans Bold", serif;
  text-transform: uppercase;
  border: solid #f39c12 3px;
}

.pricing-table .table-basic:hover .stroke-price {
  background-color: #f39c12;
  border-top: none;
  border-left: none;
  border-right: solid #f39c12;
  border-bottom: none;
}
.pricing-table .table-basic:hover .stroke-price h4, .pricing-table .table-basic:hover h3 {
  color: #fff;
}
.pricing-table .table-basic:hover .stroke-button {
  border-bottom: solid #e6e6e6 15px;
}
.pricing-table .table-basic:hover .orange-line {
  background-color: #fff;
}
.pricing-table .table-basic:hover ol {
  background-color: #e6e6e6;
  border: solid transparent 0.1px;
}
.pricing-table .table-basic:hover li {
  background-color: #f2f2f2;
  border: solid transparent 0.1px;
}

.pricing-table .table-basic:hover {
  border-top: solid #f39c12 15px;
}

.pricing-table .table-basic button:hover {
  background-color: #f39c12;
  color: #fff;
}

.pricing-table .table-gold:hover .stroke-price {
  background-color: #f39c12;
  border-top: solid #f39c12;
}
.pricing-table .table-gold:hover .stroke-price h4, .pricing-table .table-gold:hover h3 {
  color: #fff;
}
.pricing-table .table-gold:hover .stroke-button {
  border-bottom: solid #e6e6e6 15px;
}
.pricing-table .table-gold:hover .orange-line {
  background-color: #fff;
}
.pricing-table .table-gold:hover ol {
  background-color: #e6e6e6;
  border: solid transparent 0.1px;
}
.pricing-table .table-gold:hover li {
  background-color: #f2f2f2;
  border-top: none;
  border-bottom: none;
}

.pricing-table .table-gold:hover {
  border-top: solid #f39c12 15px;
}

.pricing-table .table-gold button:hover {
  background-color: #f39c12;
  color: #fff;
}

/*# sourceMappingURL=main.cs.map */
