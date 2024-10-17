const API_KEY = 'cf9651afab0c054059311c2ce8b9e892';  
const BASE_URL = 'https://api.openweathermap.org/data/2.5/';

async function getWeather() {
    const city = document.getElementById('cityInput').value.trim();
    if (!city) {
        alert('Please enter a city name.');
        return;
    }

    try {
        const weatherResponse = await fetch(`${BASE_URL}weather?q=${city}&appid=${API_KEY}&units=metric`);
        if (!weatherResponse.ok) {
            if (weatherResponse.status === 404) {
                throw new Error('City not found. Please check the city name.');
            }
            throw new Error('Network response was not ok');
        }
        const weatherData = await weatherResponse.json();
        displayCurrentWeather(weatherData);
        displayMap(weatherData.coord.lat, weatherData.coord.lon); 

        const forecastResponse = await fetch(`${BASE_URL}forecast?q=${city}&appid=${API_KEY}&units=metric`);
        if (!forecastResponse.ok) {
            throw new Error('Network response was not ok');
        }
        const forecastData = await forecastResponse.json();
        displayForecast(forecastData);

    } catch (error) {
        console.error('Error fetching data:', error);
        alert('Failed to fetch weather data: ' + error.message);
    }
}

function displayCurrentWeather(data) {
    const weatherBody = document.getElementById('weatherBody');
    weatherBody.innerHTML = `
        <tr>
            <td>${data.name}, ${data.sys.country}</td>
            <td>${data.main.temp}°C</td>
            <td>${data.weather[0].description}</td>
            <td>${data.sys.country}</td>
            <td><img src="http://openweathermap.org/img/wn/${data.weather[0].icon}.png" alt="${data.weather[0].description} icon" /></td>
        </tr>
    `;
}

function displayForecast(data) {
    const forecastBody = document.getElementById('forecastBody');
    forecastBody.innerHTML = '';

    const dailyForecasts = data.list.filter(item => item.dt_txt.includes('12:00:00'));
    dailyForecasts.forEach(forecast => {
        const date = new Date(forecast.dt_txt).toLocaleDateString();
        forecastBody.innerHTML += `
            <tr>
                <td>${date}</td>
                <td>${forecast.main.temp}°C</td>
                <td>${forecast.weather[0].description}</td>
                <td><img src="http://openweathermap.org/img/wn/${forecast.weather[0].icon}.png" alt="${forecast.weather[0].description} icon" /></td>
            </tr>
        `;
    });
}

function displayMap(lat, lon) {
    const map = L.map('map').setView([lat, lon], 13);
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '© OpenStreetMap'
    }).addTo(map);
    
    L.marker([lat, lon]).addTo(map)
        .bindPopup('City Location')
        .openPopup();
}