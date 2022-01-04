import React from 'react';
import { Provider } from 'react-redux';
import Board from './components/Board';
import store from './store'


function App() {
    return (
        <Provider store={store}>
             <Board/>
        </Provider>
    
    );
  }
  
  export default App;