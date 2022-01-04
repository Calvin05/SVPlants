import { FETCH_PLANTS, UPDATE_PLANT } from "./types";

//Get list of Plants from backend
export const fetchPlants = () => dispatch => {
    const url = 'http://localhost:54026/api/plants';
    fetch(url)
    .then(res => res.json())
    .then(plants => dispatch({
        type: FETCH_PLANTS,
        payload: plants
    }));
    
}

//Update the time plant has been watered
export const updatePlant = (id) => dispatch => {
    const url = 'http://localhost:54026/api/plant/';
     fetch(url + id, {
         method: 'POST'
     })
     .then(res => res.json())
     .then(plant => dispatch({
        type: UPDATE_PLANT,
        payload: plant 
     }))
}


