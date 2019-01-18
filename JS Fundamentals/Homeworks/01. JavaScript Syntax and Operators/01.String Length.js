function solve(str1, str2, str3) {
    let str1Len = str1.length;
    let str2Len = str2.length;
    let str3Len = str3.length;

    let sumLen = str1Len + str2Len + str3Len;
    let averageLen = Math.floor(((str1Len + str2Len + str3Len) / 3));
    console.log(sumLen);
    console.log(averageLen);
}

solve('testis', 'kaval', 'va');