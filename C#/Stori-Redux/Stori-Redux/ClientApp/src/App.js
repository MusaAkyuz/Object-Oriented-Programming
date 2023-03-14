import React from 'react';
import NavbarMenu from './features/NavbarMenu/NavbarMenu'
import store from './store'

console.log(store.getState())

function App() {
    return (
        <>
            <NavbarMenu />
        </>     
    );
}

export default App
