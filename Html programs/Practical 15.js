window.onload = function() {
    loadTasks();
};
function addTask() {
    const taskInput = document.getElementById('taskInput');
    const taskList = document.getElementById('taskList');

    if (taskInput.value.trim() !== '') {
        const li = document.createElement('li');
        li.innerHTML = `${taskInput.value} <button onclick="deleteTask(this)">Delete</button>`;
        taskList.appendChild(li);

        saveTaskToLocalStorage(taskInput.value);
        taskInput.value = '';
    }
}
function deleteTask(taskElement) {
    const taskItem = taskElement.parentElement;
    taskItem.remove();
    removeTaskFromLocalStorage(taskItem.textContent.replace('Delete', '').trim());
}
function clearAllTasks() {
    const taskList = document.getElementById('taskList');
    taskList.innerHTML = '';
    localStorage.clear();
}
function saveTaskToLocalStorage(task) {
    let tasks = JSON.parse(localStorage.getItem('tasks')) || [];
    tasks.push(task);
    localStorage.setItem('tasks', JSON.stringify(tasks));
}
function loadTasks() {
    const tasks = JSON.parse(localStorage.getItem('tasks')) || [];
    tasks.forEach(task => {
        const li = document.createElement('li');
        li.innerHTML = `${task} <button onclick="deleteTask(this)">Delete</button>`;
        document.getElementById('taskList').appendChild(li);
    });
}
function removeTaskFromLocalStorage(task) {
    let tasks = JSON.parse(localStorage.getItem('tasks')) || [];
    tasks = tasks.filter(t => t !== task);
    localStorage.setItem('tasks', JSON.stringify(tasks));
}
