import styles from './lastestCars.module.css'
import { CarCard } from 'entities/car/car-card'

export const LastestCars = () =>{
    return (
        <div className={styles.wrapper}>
            <div className={styles.titleContainer}>
                <h5>Lastest Cars</h5>
            </div>
            <div className={styles.listContainer}>
                <CarCard />
                <CarCard />
                <CarCard />
                <CarCard />
                <CarCard />
                <CarCard />
            </div>
        </div>
    )
}