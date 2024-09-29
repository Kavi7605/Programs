let students = [];

function displayStudents() {
    const tbody = document.querySelector('#studentTable tbody');
    tbody.innerHTML = ''; 

    students.forEach((student, index) => {
        const row = `
            <tr>
                <td>${student.name}</td>
                <td>${student.age}</td>
                <td>${student.grade}</td>
                <td>
                    <button class="edit-btn" onclick="editStudent(${index})">Edit</button>
                    <button class="delete-btn" onclick="deleteStudent(${index})">Delete</button>
                </td>
            </tr>
        `;
        tbody.innerHTML += row;
    });
}

function addOrEditStudent() {
    const studentName = document.getElementById('studentName').value;
    const studentAge = document.getElementById('studentAge').value;
    const studentGrade = document.getElementById('studentGrade').value;
    const studentIndex = document.getElementById('studentIndex').value;

    if (studentName === '' || studentAge === '' || studentGrade === '') {
        alert('Please fill in all fields.');
        return;
    }

    const studentData = {
        name: studentName,
        age: parseInt(studentAge),
        grade: studentGrade
    };

    if (studentIndex !== '') {
        students[studentIndex] = studentData;
    } else {
        students.push(studentData);
    }

    resetForm();
    displayStudents();
}

function resetForm() {
    document.getElementById('studentName').value = '';
    document.getElementById('studentAge').value = '';
    document.getElementById('studentGrade').value = '';
    document.getElementById('studentIndex').value = '';
}

function editStudent(index) {
    const student = students[index];
    document.getElementById('studentName').value = student.name;
    document.getElementById('studentAge').value = student.age;
    document.getElementById('studentGrade').value = student.grade;
    document.getElementById('studentIndex').value = index;
}

function deleteStudent(index) {
    const confirmDelete = confirm('Are you sure you want to delete this student?');
    if (confirmDelete) {
        students.splice(index, 1); 
        displayStudents(); 
    }
}

displayStudents();
