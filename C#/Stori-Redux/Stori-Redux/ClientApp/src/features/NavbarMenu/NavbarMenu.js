import './NavbarMenuStyle.css'
import { createTheme, ThemeProvider } from '@mui/material/styles';
//import React, { useState } from "react";
import Slider from '@mui/material/Slider';
import Box from '@mui/material/Box';
import { useSelector, useDispatch } from 'react-redux'

const NavbarMenu = () => {

    const store = useSelector(state => state.TextSettings)

    //// Redux Store da tutulacak textColor değeri için state ayarı
    //// Dispatch ile değişikliği store a kaydedecek
    //const [textColor, setTextColor] = useState("white")
    //// Redux storeda tutlacak slider değeri okuma hızını ayarlayacak
    //const [sliderValue, setSliderValue] = useState(50)

    const dispatch = useDispatch()

    const changeTextColor = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        //setTextColor("#" + randomColor)
        dispatch({ type: 'navbarmenu/textSettingsChange', payload: ['#' + randomColor, store.speed] })
    };

    const changeSliderValue = (event) => {
        //setSliderValue(event.target.value)
        dispatch({ type: 'navbarmenu/textSettingsChange', payload: [store.textColor, event.target.value] })
    }

    const theme = createTheme({
        palette: {
            slider: {
                main: store.textColor,
                contrastText: '#fff',
            },
        },
    });

    return (
        <div className="navmenu w-">
            <div className="logotextdiv">
                <p className="storifont" style={{ color: store.textColor }}>
                    Stori
                </p>
            </div>
            <div className="settingsdiv">
                <div className="boxClass">
                    <label className="px-3" style={{ color: store.textColor }}>Speed</label>
                    <ThemeProvider theme={theme}>
                        <Slider
                            aria-label="Small steps"
                            defaultValue={30}
                            color="slider"
                        />
                    </ThemeProvider>
                </div>
                <div className="boxClass displayStyle">
                    <label className="px-3" style={{ color: store.textColor }}>Text Color</label>
                    <button type="button"
                        className="btn"
                        onClick={changeTextColor}
                        style={{ color: store.textColor, backgroundColor: store.textColor }}
                    >A</button>
                </div>
            </div>
        </div>
    );
}

export default NavbarMenu