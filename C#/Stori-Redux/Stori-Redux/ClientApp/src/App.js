import React from 'react';
import AppRoutes from './AppRoutes';
import { Route, Routes } from 'react-router-dom';
import NavbarMenu from './features/NavbarMenu/NavbarMenu'

function App() {
    return (
        <>
            <NavbarMenu />
            <Routes>
                {AppRoutes.map((route, index) => {
                    const { element, ...rest } = route;
                    return <Route key={index} {...rest} element={element} />;
                })}
            </Routes>
            
        </>     
    );
}

export default App
