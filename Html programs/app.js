let students = [];
let editingIndex = null;

// Function to add or update a student
function addStudent(name, age, grade, semester, address, gender, hobbies) {
    const student = { name, age, grade, semester, address, gender, hobbies };
    students.push(student);
}

// Function to display students in the table
function displayStudents() {
    const tableBody = document.getElementById("studentTableBody");
    tableBody.innerHTML = ""; // Clear the table body

    students.forEach((student, index) => {
        const hobbiesList = student.hobbies.join(", ");
        const row = `
            <tr>
                <td>${student.name}</td>
                <td>${student.age}</td>
                <td>${student.grade}</td>
                <td>${student.semester}</td>
                <td>${student.address}</td>
                <td>${student.gender}</td>
                <td>${hobbiesList}</td>
                <td>
                    <button class="btn btn-warning btn-sm" onclick="editStudent(${index})">Edit</button>
                    <button class="btn btn-danger btn-sm" onclick="deleteStudent(${index})">Delete</button>
                </td>
            </tr>
        `;
        tableBody.innerHTML += row;
    });
}

// Handle form submission
document.getElementById("studentForm").addEventListener("submit", function (event) {
    event.preventDefault();

    const name = document.getElementById("name").value;
    const age = document.getElementById("age").value;
    const grade = document.getElementById("grade").value;
    const semester = document.getElementById("semester").value;
    const address = document.getElementById("address").value;
    
    const gender= document.getElementById("gender").value;

    const hobbies = [];
    document.querySelectorAll('input[name="hobbies"]:checked').forEach((checkbox) => {
        hobbies.push(checkbox.value);
    });

    if (editingIndex !== null) {
        students[editingIndex] = { name, age, grade, semester, address, gender, hobbies };
        editingIndex = null;
    } else {
        addStudent(name, age, grade, semester, address, gender, hobbies);
    }

    displayStudents();

    // Reset form fields
    document.getElementById("studentForm").reset();
});

// Function to edit a student
function editStudent(index) {
    const student = students[index];
    document.getElementById("name").value = student.name;
    document.getElementById("age").value = student.age;
    document.getElementById("grade").value = student.grade;
    document.getElementById("semester").value = student.semester;
    document.getElementById("address").value = student.address;
    document.getElementById("gender").value = student.gender;

    // Reset hobbies checkboxes and set according to the selected student
    document.querySelectorAll('input[name="hobbies"]').forEach((checkbox) => {
        checkbox.checked = student.hobbies.includes(checkbox.value);
    });

    document.querySelector("button[type=submit]").innerText = "Save";
    editingIndex = index;
}

// Function to delete a student
function deleteStudent(index) {
    students.splice(index, 1); // Remove student from array
    displayStudents(); // Refresh the table
}
