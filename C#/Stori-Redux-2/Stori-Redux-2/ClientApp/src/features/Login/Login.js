import './LoginStyle.css';
import { useSelector, useDispatch } from 'react-redux';
import { Flex, TextField, ActionButton } from '@adobe/react-spectrum';

const Login = () => {

    const store = useSelector(state => state.TextSettings)

    return (
        <div className="color">
            <Flex direction="column" justifyContent="center" alignItems="center" columnGap="size-1000">
                <TextField label="Name" labelPosition="side" width="size-2000" />
                <ActionButton marginStart="size-150">Submit</ActionButton>
            </Flex>


        </div>
    )
}

export default Login