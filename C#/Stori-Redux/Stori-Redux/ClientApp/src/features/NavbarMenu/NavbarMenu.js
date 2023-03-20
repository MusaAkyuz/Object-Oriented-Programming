import './NavbarMenuStyle.css'
//import React, { useState } from "react";
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

    return (
        <div className="navmenu w-">
            <div className="logotextdiv">
                <p className="storifont" style={{ color: store.textColor }}>
                    Stori
                </p>
            </div>
            <div className="settingsdiv">
                <form className="form-inline settingsfont">
                    <label className="px-3" style={{ color: store.textColor }}>Speed</label>
                    <input onChange={changeSliderValue}
                        type="range" min={1} max={100} value={store.speed} step={1} />
                </form>
                <form className="form-inline settingsfont">
                    <label className="px-3" style={{ color: store.textColor }}>Text Color</label>
                    <button type="button"
                        className="btn"
                        onClick={changeTextColor}
                        style={{ color: store.textColor, backgroundColor: store.textColor }}
                    >A</button>
                </form>
            </div>
        </div>
    );
}

export default NavbarMenu