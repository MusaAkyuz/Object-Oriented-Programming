import './NavbarMenuStyle.css'
import React, { useState } from "react";
import { useDispatch } from 'react-redux'
import { textColorChanged } from './NavbarMenuSlice'

const NavbarMenu = () => {

    // Redux Store da tutulacak textColor değeri için state ayarı
    // Dispatch ile değişikliği store a kaydedecek
    const [textColor, setTextColor] = useState("white")
    // Redux storeda tutlacak slider değeri okuma hızını ayarlayacak
    const [sliderValue, setSliderValue] = useState(50)

    const dispatch = useDispatch()

    const changeTextColor = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        setTextColor("#" + randomColor)
        dispatch({ type: 'navbarmenu/textSettingsChange', payload: ['#' + randomColor, sliderValue] })
    };

    const changeSliderValue = (event) => {
        setSliderValue(event.target.value)
        dispatch({ type: 'navbarmenu/textSettingsChange', payload: [textColor, event.target.value] })
    }

    return (
        <div className="navmenu">
            <div className="logotextdiv">
                <p className="storifont" style={{ color: textColor }}>
                    Stori
                </p>
            </div>
            <div className="settingsdiv">
                <form className="form-inline settingsfont">
                    <label className="px-3" style={{ color: textColor }}>Speed</label>
                    <input onChange={changeSliderValue}
                        type="range" min={1} max={100} value={sliderValue} step={1}/>
                </form>
                <form className="form-inline settingsfont">
                    <label className="px-3" style={{ color: textColor }}>Text Color</label>
                    <button type="button"
                        className="btn"
                        onClick={changeTextColor}
                        style={{ color: textColor, backgroundColor: textColor }}
                    >A</button>
                </form>
            </div>
        </div>
    );
}

export default NavbarMenu