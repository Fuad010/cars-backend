import { carModel } from 'entities/car';
import styles from './carCardAction.module.css'

interface Props = {
    car: Car;
};

export const CarCardAction = ({car}: Props) => {
    const {store: { deleteCar }} = carModel
    return(
        <button  style={{width:"100%", height:"100%"}}>asdasdad</button>
    )
}