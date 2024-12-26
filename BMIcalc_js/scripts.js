let height, weight, bmi;
let choice = prompt(
	"metric or imperial units? type 1 for metric, 2 for imperial: "
);

function metric_bmi(height, weight) {
	return weight / Math.pow(height, 2);
}

function imperial_bmi(height, weight) {
	return (weight * 703) / Math.pow(height, 2);
}

if (choice === "1") {
	height = prompt("please input height in cm: ") / 100;
	weight = prompt("please input weight in kg: ");
	bmi = metric_bmi(height, weight);
} else if (choice === "2") {
	height = prompt("please input height in inches: ");
	weight = prompt("please input weight in lbs: ");
	bmi = imperial_bmi(height, weight);
} else {
	console.log("invalid input");
}

console.log("your bmi is " + bmi);
switch (true) {
	case bmi < 18.4:
		console.log("You are underweight!");
		break;
	case 18.4 < bmi && bmi < 24.9:
		console.log("Good weight!");
		break;
	case 24.9 < bmi && bmi < 39.9:
		console.log("You are overweight!");
		break;
	case bmi > 39.9:
		console.log("You are obese!");
		break;
}
