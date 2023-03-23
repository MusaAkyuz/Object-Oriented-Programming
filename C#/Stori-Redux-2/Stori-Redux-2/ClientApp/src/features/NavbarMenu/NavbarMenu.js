import './NavbarMenuStyle.css'
import Slider from '@mui/material/Slider';
import { useNavigate } from "react-router-dom";
import { useSelector, useDispatch } from 'react-redux'
import { createTheme, ThemeProvider } from '@mui/material/styles';

const NavbarMenu = () => {

    const store = useSelector(state => state.TextSettings)
    const navigate = useNavigate()
    const dispatch = useDispatch()

    const changeTextColor = () => {
        const randomColor = Math.floor(Math.random() * 16777215).toString(16);
        dispatch({ type: 'navbarmenu/textSettingsChange', payload: ['#' + randomColor, store.speed] })
    };

    const changeSliderValue = (event) => {
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

    const turnBooksPage = () => {
        navigate("/books")
    }

    return (
        <div className="navmenu font">
            <div className="logotextdiv" onClick={() => turnBooksPage()}>
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
                            value={store.speed}
                            onChange={changeSliderValue}
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