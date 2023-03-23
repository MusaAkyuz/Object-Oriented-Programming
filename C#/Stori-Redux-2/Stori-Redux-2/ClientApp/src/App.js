import "./custom.css"
import AppRoutes from './AppRoutes';
import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import NavbarMenu from './features/NavbarMenu/NavbarMenu'

export default class App extends Component {
  static displayName = App.name;

  render() {
      return (
            <>
                <NavbarMenu />
                <Routes class="position">
                    {AppRoutes.map((route, index) => {
                        const { element, ...rest } = route;
                        return <Route key={index} {...rest} element={element} />;
                    })}
                </Routes>  
            </>
       
      );
  }
}
