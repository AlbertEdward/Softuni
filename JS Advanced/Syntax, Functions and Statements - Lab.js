//01. Echo Function
function solve1(input) {
    let count = 0;
    for (let i = 0; i < input.length; i++) {
        count ++;
    }
    return count + '\n' + input;
}
console.log(solve1('Hello, JavaScript!'));

//02. String Length
function solve2(string1, string2, string3) {
    let stringSum = string1.length + string2.length + string3.length;
    let average = stringSum / 3;
    return stringSum + '\n' + Math.floor(average);
}
console.log(solve2('chocolate', 'ice cream', 'cake'));

//03. Largest Number
function solve3(num1, num2, num3) {
    let max = Math.max(num1, num2, num3);
    return 'The largest number is ' + max + '.';
}
console.log(solve3(5, -3, 16));

//04. Circle Area
function solve4(radius) {
    if (typeof(radius) == 'number') {
        let area = Math.PI * radius * radius;
        return area.toFixed(2);
    }
    else {
        return 'We can not calculate the circle area, because we receive a ' + typeof(radius) + '.';
    }
}
console.log(solve4(5));

//05. Math Operations
function solve5(num1, num2, string) {
    if(string == '+') {
        return num1 + num2;
    }
    else if(string == '-') {
        return num1 - num2;
    }
    else if(string == '*') {
        return num1 * num2;
    }
    else if(string == '/') {
        return num1 / num2;
    }
    else if(string == '%') {
        return num1 % num2;
    }
    else if(string == '**') {
        return num1 ** num2;
    }
}
console.log(solve5(5, 6, '+'));

//06. Sum of Numbers N…M
function solve6(n, m) {
    let n1 = Number(n);
    let m1 = Number(m); 
    let totalSum = 0;
    for (let i = n1; i <= m1; i++) {
        totalSum += i;
    }
    return totalSum;
}
console.log(solve6('1', '5'));

//07. Day of Week
function solve7(dayOfWeek) {
    if(dayOfWeek == 'Monday') {
        return '1';
    }
    else if(dayOfWeek == 'Tuesday') {     
        return '2';
    }
    else if(dayOfWeek == 'Wednesday') {
        return '3';
    }
    else if(dayOfWeek == 'Thursday') {
        return '4';
    }
    else if(dayOfWeek == 'Friday') {
        return '5';
    }
    else if(dayOfWeek == 'Saturday') {
        return '6';
    }
    else if(dayOfWeek == 'Sunday') {
        return '7';
    }
    else {
        return 'error';
    }
}
console.log(solve7(5));

//08. Days in a month
function solve8(month, year) {

    if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
        return '31';
    }
    else if(month == 4 || month == 6 || month == 9 || month == 11) {
        return '30';
    }
    else if(month == 2) {
        if(year % 4 == 0) {
            return '29';
        }
        else {
            return '28';
        }
    }
    else {
        return 'error';
    }
}
console.log(solve8(2, 2021));

//09. Square of Stars
function solve9(n) {

    let newLine = '\n';

    for(col = 1; col <= n; col++){

        let star = '';

        for (let row = 1; row <= n; row++) {
            star += '*' + ' ';
        }
        console.log(star)
    }
}
solve9(5);

//10. Aggregate Elements

let aggregateElements = (array) => {

    let numbersArray = array.map(Number);
    let sum = numbersArray.reduce((a, b) => a + b);

    let inverseValuesSum = 0;
 
    for (let i = 0; i < numbersArray.length; i++) {
        inverseValuesSum += 1 / numbersArray[i];
    }

    let stringConcat = numbersArray.join('');

    console.log(sum);
    console.log(inverseValuesSum);
    console.log(stringConcat);
}
aggregateElements([1, 2, 3]);