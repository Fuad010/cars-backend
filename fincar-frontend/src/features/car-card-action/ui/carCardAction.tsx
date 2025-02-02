import { carModel } from 'entities/car';
import styles from './carCardAction.module.css'
import { Car } from 'shared/api/cars/model';

interface Props {
    car: Car;
};

export const CarCardAction = ({ car }: Props) => {
    const { store: { deleteCar} } = carModel

    const handleDeleteClick = (e: React.MouseEvent) => {
        e.stopPropagation();
        deleteCar(car.id);
        
    };

    return (
        <div className={styles.box}>
            <div>
                <button className={styles.updateBtn}>Edit Car</button>
                <button onClick={handleDeleteClick} className={styles.deleteBtn}>Delete Car</button>
            </div>
        </div>
    )
}