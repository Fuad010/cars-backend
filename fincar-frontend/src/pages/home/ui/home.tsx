import { LastestCars } from "widgets/lastest-cars-list"
import styles from './home.module.css'
import { CarListPagination } from "widgets/car-list-pagination"

export const Home = () => {
    return (
        <div className={styles.wrapper}>
            <LastestCars />
            <CarListPagination />
        </div>
    )
}