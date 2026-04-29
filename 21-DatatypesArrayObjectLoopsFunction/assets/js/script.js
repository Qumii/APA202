// 1.Verilmis arrayde tekrarlanan reqemleri silmek ve tekrar reqemlerin sayini gostermek.

// function removeDublicate(arr) {
//     let newArray = []
//     let deleteCount = 0


//     for (let i = 0; i < arr.length; i++) {
//         let isExist =false

//         for (let j = 0; j < newArray.length; j++) {
//             if (arr[i] === newArray[j] ){
//                 isExist = true
//                 break

//             }

//         }

//         if (isExist === false) {
//             newArray.push(arr[i])

//         }else{
//             deleteCount++;
//         }

//     }

//     console.log('Tekrarlardan temizlenmis massiv:', newArray);
//     console.log('Silinen tekrar reqemlerin sayi:', deleteCount);

// }

// removeDublicate([1,2,3,4,4,5,5,5,6,6])





// =========================================================================================================





// 2.Verilmis sozun polindrom olub olmadığını yoxlayan alqoritm yazmaq.


// function checkPolindrom(word) {

//     let reverseWord = ""

//     for (let i = word.length-1; i >=0; i--) {
//         reverseWord += word[i]

//     }

//     if (word === reverseWord) {

//         console.log(word + ' - polidromdur');
//     }else{
//         console.log(word + ' - polidrom deyil');

//     }
// }

// checkPolindrom('kitab')




// ======================================================================================================




// 3.Girilen ededin verilmis arreyde nece elementden kicik oldugunu yazan alqoritim.


// function countIsSmall(num, arr) {
//   let count = 0;

//   for (let i = 0; i < arr.length; i++) {

//     if (num < arr[i]) {
//         count++

//     }
//   }

//   console.log(count);


// }

// countIsSmall(4, [2,3,6,7,11,8])




// =========================================================================================================




// 4.Daxil edilen ededin Aboundant ve ya Deficient oldugunu yoxlayan algorithm.(Abundant ədəd öz müsbət bolenlerinin(ozunden basqa) cəmi özündən böyük olan müsbət tam ədədlərə deyilir. Eks halda Deficient eded olur. 12-Aboundant, 13- Deficient)


// function checkNumber(n) {
//     let sumDivide=0

//     for (let i = 1; i < n; i++) {
//         if (n%i===0) {
//             sumDivide += i

//         }

//     }

//     if (sumDivide >n) {
//         console.log(n + ' - aboundantdir');
//     }else{
//         console.log(n + ' - deficientdir');
//     }
// }

// checkNumber(15)




// =========================================================================================================



// 5.Array-in bütün elementlərini kvadrata yüksəldib yeni array qaytaran funksiya yazın.

function squareArray(arr) {
  let resultArray = [];


  for (let i = 0; i < arr.length; i++) {
    let square = arr[i] ** 2;

    resultArray.push(square)

  }

  return resultArray;

}

let numbers = [2, 4, 6, 11, 7];
let squareNumbers = squareArray(numbers);

console.log("Kvadrata yukseldilmis array: ", squareNumbers);
