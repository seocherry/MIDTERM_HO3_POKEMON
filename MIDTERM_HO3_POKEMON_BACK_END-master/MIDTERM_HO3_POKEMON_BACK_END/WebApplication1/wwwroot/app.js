document.getElementById('pokemonForm').addEventListener('submit', async function (e) {
    e.preventDefault();
    const name = document.getElementById('pokemonName').value.trim().toLowerCase();
    const errorDiv = document.getElementById('error');
    const detailsDiv = document.getElementById('pokemonDetails');

    errorDiv.textContent = '';
    detailsDiv.innerHTML = '';

    if (!name) {
        errorDiv.textContent = 'Please enter a Pokémon name';
        return;
    }

    try {
        // Updated endpoint to match your controller
        const response = await fetch(`https://localhost:44353/api/pokemon/name/${name}`, {
            headers: {
                'Accept': 'application/json'
            }
        });

        if (!response.ok) {
            const errorData = await response.json();
            throw new Error(errorData.message || 'Pokémon not found');
        }

        const pokemon = await response.json();

        // Convert height/weight from API (decimeters/hectograms) to meters/kg
        const heightInMeters = (pokemon.height / 10).toFixed(1);
        const weightInKg = (pokemon.weight / 10).toFixed(1);

        detailsDiv.innerHTML = `
            <h2>${pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1)}</h2>
            <img class="pokemon-image" src="${pokemon.imageUrl}" alt="${pokemon.name}">
            <p><strong>Type:</strong> ${pokemon.types.join(', ')}</p>
            <p><strong>Height:</strong> ${heightInMeters} m</p>
            <p><strong>Weight:</strong> ${weightInKg} kg</p>
            ${pokemon.evolutions?.next ?
                `<p><strong>Evolves to:</strong> ${pokemon.evolutions.next.name}</p>` : ''}
        `;
    } catch (err) {
        errorDiv.textContent = err.message;
        console.error('Fetch error:', err);
    }
});