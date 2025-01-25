import { useEffect } from 'react'
import styles from './lastestCars.module.css'
import { CarCard } from 'entities/car/car-card'
import { carModel } from 'entities/car'
import { CardSkeleton } from 'shared/ui/cardSkeleton'
import { observer } from 'mobx-react-lite'

export const LastestCars = observer(() =>{
    const { store: { getCarList, carListError, carList, isLoading  } } 
    = carModel
    
    useEffect(() => {
        getCarList(10);
    }, [])

    if (carListError) {
        return<>{carListError}</>
    }
    console.log(carList);
    
    return (
        <div className={styles.wrapper}>
            <div className={styles.titleContainer}>
                <h5>Lastest Cars</h5>
            </div>
            <div className={styles.listContainer}>


                {isLoading ? ( 
                    <div className={styles.skeletonContainer}>
                        <CardSkeleton /> 
                        <CardSkeleton /> 
                        <CardSkeleton /> 
                    </div>
            ) : ( 
                carList.map((car)=>(
                    <CarCard
                        key={car.id}
                        brandName={car.brandName}
                        name={car.name}
                        engine={car.engine}
                        year={car.year}
                        mileage={car.mileage}
                        price={car.price}
                        image={car.images[0]}
                    />
                )))}
                
            </div>
        </div>
    )
})