// button.onclick = function(){
	// buttonFunction();
// };

button.addEventListener("click", function(){
	buttonFunction();
});

function buttonFunction(){
	let p = document.getElementById("paragraph");
	let gender = document.getElementsByName("gender");
	let dipilih;
	for(let i = 0; i < gender.length; i++){
		if(gender[i].checked){
			dipilih = gender[i].value;
		}
	}
	
	// if(gender[0].checked){
		// dipilih = gender[0].value;
	// }else{
		// dipilih = gender[1].value;
	// }
	
	p.innerText = pilihan.value + " " + dipilih;
}