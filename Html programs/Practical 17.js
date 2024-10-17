document.getElementById('githubForm').addEventListener('submit', function (e) {
    e.preventDefault();
    const username = document.getElementById('usernameInput').value;
    if (username) {
        fetchGitHubProfile(username);
    } else {
        alert('Please enter a GitHub username.');
    }
});

async function fetchGitHubProfile(username) {
    try {
        const response = await fetch(`https://api.github.com/users/${username}`);
        if (!response.ok) {
            throw new Error('User not found');
        }
        const profileData = await response.json();
        displayProfile(profileData);
        fetchRepositories(username);
    } catch (error) {
        alert('Error: ' + error.message);
    }
}

function displayProfile(data) {
    const profileDiv = document.getElementById('profile');
    profileDiv.innerHTML = `
        <div class="profile-info">
            <img src="${data.avatar_url}" alt="Avatar">
            <h2>${data.name || data.login}</h2>
            <p>Followers: ${data.followers} | Repos: ${data.public_repos}</p>
        </div>
    `;
}

async function fetchRepositories(username) {
    try {
        const response = await fetch(`https://api.github.com/users/${username}/repos`);
        const reposData = await response.json();
        displayRepositories(reposData);
    } catch (error) {
        alert('Error fetching repositories');
    }
}

function displayRepositories(repos) {
    const profileDiv = document.getElementById('profile');
    const repoList = document.createElement('div');
    repoList.classList.add('repo-list');

    repoList.innerHTML = '<h3>Repositories:</h3>';

    repos.forEach(repo => {
        repoList.innerHTML += `
            <div class="repo-item">
                <a href="${repo.html_url}" target="_blank">${repo.name}</a>
            </div>
        `;
    });

    profileDiv.appendChild(repoList);
}
