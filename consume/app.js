$.get("http://localhost:58085/getall", showData);
	
function showData(employees){
	let table = $("#employee-table");
	let tbody = table.find("tbody");
	for(let i = 0; i < employees.length; i++){
		let tr = 
		`<tr>
			<td>${employees[i].EMPLOYEE_ID}</td>
			<td>${employees[i].FIRST_NAME}</td>
			<td>${employees[i].LAST_NAME}</td>
			<td><a href="./index.html?id=${employees[i].EMPLOYEE_ID}">Get</a></td>
			<td><a href="./index.html?action=edit&id=${employees[i].EMPLOYEE_ID}">Edit</a></td>
		</tr>`;
		
		tbody.append(tr);
	}
}

let queryString = new URLSearchParams(location.search);
if(queryString.has("id")){
	let id = queryString.get("id");
	$.get(`http://localhost:58085/api/values/${id}`, showEmployee);
}

function showEmployee(employee){
	$("#employee").text(employee.FIRST_NAME);
}

function postData(){
	let employeeId = $("#employee_id").val();
	let firstName = $("#first_name").val();
	let lastName = $("#last_name").val();
	let jsonData = {
		"EMPLOYEE_ID": employeeId,
		"FIRST_NAME": firstName,
		"LAST_NAME": lastName
	};
	$.post("http://localhost:58085/api/values", 
			jsonData, postDataCallback);
}

function postDataCallback(message){
	alert(message);
}