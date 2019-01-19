function calorie(input) {
    let output = '';
    output += ("{ ");

    for (let i = 0; i < input.length; i++) {
        if (i % 2 == 0) {

            output += (`${input[i]}: `);
        } else {
            output += `${input[i]}, `
        }
    }
    output = output.replace(/,\s*$/, "");
    output += (' }');
    console.log(output)
}

calorie(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]);